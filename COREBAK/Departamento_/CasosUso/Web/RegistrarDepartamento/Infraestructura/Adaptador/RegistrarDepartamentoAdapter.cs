using COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Dominio.Interface;
using COREBAK.Departamento_.Entidad.Base;
using COREBAK.Departamento_.Entidad.DataBaseContext;

namespace COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Infraestructura.Adaptador
{
    public class RegistrarDepartamentoAdapter : IRegistrarDepartamento
    {
        public readonly DepartamentoDataBaseContext _context;

        public RegistrarDepartamentoAdapter(DepartamentoDataBaseContext context)
        {
            _context = context;
        }

        public async Task RegistrarDepartamento(Departamento departamento)
        {
            _context.DepartamentoDBContext.Add(departamento);
            await _context.SaveChangesAsync();
        }
    }
}
