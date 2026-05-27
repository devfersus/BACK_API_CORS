using COREBAK.TipoListado_.Entidad.Base;
using COREBAK.TipoListado_.Entidad.DataBaseContext;
using COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Dominio.Interface;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Infraestructura.Adapter
{
    public class ObtenerTipoListadoPorIdAdapter : IObtenerTipoListadoPorIdRepository
    {
        private readonly TipoListadoDataBaseContext _context;

        public ObtenerTipoListadoPorIdAdapter(TipoListadoDataBaseContext context)
        {
            _context = context;
        }

        public async Task<TipoListado> ObtenerPorIdAsync(Guid tipoListadoId)
        {
            return await _context.TipoListadoDBContext
                .FirstOrDefaultAsync(t => t.TipoListadoId == tipoListadoId);
        }
    }
}