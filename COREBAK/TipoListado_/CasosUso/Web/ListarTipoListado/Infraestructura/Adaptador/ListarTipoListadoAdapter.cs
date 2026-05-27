using COREBAK.TipoListado_.CasosUso.Web.ListarTipoListado.Dominio.Interface;
using COREBAK.TipoListado_.Entidad.Base;
using COREBAK.TipoListado_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.TipoListado_.CasosUso.Web.ListarTipoListado.Infraestructura.Adaptador
{
    public class ListarTipoListadoAdapter : IListarTipoListado
    {
        public readonly TipoListadoDataBaseContext _context;

        public ListarTipoListadoAdapter(TipoListadoDataBaseContext context)
        {
            _context = context;
        }

        public async Task<List<TipoListado>> ListarTipoListado()
        {
            return await _context.TipoListadoDBContext
                .ToListAsync();
        }
    }
}