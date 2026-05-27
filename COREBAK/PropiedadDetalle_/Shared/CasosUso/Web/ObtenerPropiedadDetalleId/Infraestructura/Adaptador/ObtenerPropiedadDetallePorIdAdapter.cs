using COREBAK.PropiedadDetalle_.Entidad.Base;
using COREBAK.PropiedadDetalle_.Entidad.DataBaseContext;
using COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ObtenerPropiedadDetalleId.Dominio.Interface;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ObtenerPropiedadDetalleId.Infraestructura.Adaptador
{
    public class ObtenerPropiedadDetallePorIdAdapter : IObtenerPropiedadDetallePorId
    {
        private readonly PropiedadDetalleDataBaseContext _context;

        public ObtenerPropiedadDetallePorIdAdapter(PropiedadDetalleDataBaseContext context)
        {
            _context = context;
        }

        public async Task<PropiedadDetalle> ObtenerPorIdAsync(Guid propiedadListadoId)
        {
            return await _context.PropiedadDetalleDBContext
                .Include(p => p.Fotos)
                .FirstOrDefaultAsync(p => p.PropiedadListadoId == propiedadListadoId);
        }
    }
}