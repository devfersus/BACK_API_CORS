using COREBAK.Departamento_.Entidad.Base;
using COREBAK.Departamento_.Entidad.DataBaseContext;
using COREBAK.Departamento_.Shared.CasosUso.Web.ObtenerDepartamentoPorId.Dominio.Interface;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Departamento_.Shared.CasosUso.Web.ObtenerDepartamentoPorId.Infraestructura.Adaptador
{
    public class ObtenerDepartamentoPorIdAdapter : IObtenerDepartamentoPorId
    {
        private readonly DepartamentoDataBaseContext _context;

        public ObtenerDepartamentoPorIdAdapter(DepartamentoDataBaseContext context)
        {
            _context = context;
        }

        public async Task<Departamento?> ObtenerPorIdAsync(int departamentoId)
        {
            return await _context.DepartamentoDBContext
                .FirstOrDefaultAsync(d => d.DepartamentoId == departamentoId);
        }
    }
}
