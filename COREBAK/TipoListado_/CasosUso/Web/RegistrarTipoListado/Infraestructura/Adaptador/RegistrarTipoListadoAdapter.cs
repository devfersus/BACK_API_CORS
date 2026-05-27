using COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Dominio.Interface;
using COREBAK.TipoListado_.Entidad.Base;
using COREBAK.TipoListado_.Entidad.DataBaseContext;

namespace COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Infraestructura.Adaptador
{
    public class RegistrarTipoListadoAdapter : IRegistrarTipoListado
    {
        public readonly TipoListadoDataBaseContext _context;

        public RegistrarTipoListadoAdapter(TipoListadoDataBaseContext context)
        {
            _context = context;
        }

        public async Task registrarTipoListado(TipoListado tipoListado)
        {
            _context.TipoListadoDBContext.Add(tipoListado);
            await _context.SaveChangesAsync();
        }
    }
}