using COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Dominio.Interface;
using COREBAK.Departamento_.Entidad.Base;
using COREBAK.Departamento_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Infraestructura.Adaptador
{
    public class ActualizarDepartamentoAdapter : IActualizarDepartamento
    {
        public readonly DepartamentoDataBaseContext _context;

        public ActualizarDepartamentoAdapter(DepartamentoDataBaseContext context)
        {
            _context = context;
        }

        public async Task ActualizarDepartamento(Departamento departamento)
        {
            var registro = await _context.DepartamentoDBContext
                .FirstOrDefaultAsync(d => d.DepartamentoId == departamento.DepartamentoId);

            if (registro == null)
                throw new Exception("Departamento no encontrado.");

            registro.ActualizarDepartamento(
                departamento.DepartamentoId,
                departamento.Descripcion,
                departamento.Activo
            );

            await _context.SaveChangesAsync();
        }
    }
}
