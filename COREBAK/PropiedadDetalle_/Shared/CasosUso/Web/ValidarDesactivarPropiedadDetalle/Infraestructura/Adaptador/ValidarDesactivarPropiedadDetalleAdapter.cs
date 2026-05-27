using COREBAK.PropiedadDetalle_.Entidad.Base;
using COREBAK.PropiedadDetalle_.Entidad.DataBaseContext;
using COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ValidarDesactivarPropiedadDetalle.Dominio.Interface;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ValidarDesactivarPropiedadDetalle.Infraestructura.Adaptador
{
    public class ValidarDesactivarPropiedadDetalleAdapter : IValidarDesactivarPropiedadDetalle
    {
        private readonly PropiedadDetalleDataBaseContext _context;

        public ValidarDesactivarPropiedadDetalleAdapter(PropiedadDetalleDataBaseContext context)
        {
            _context = context;
        }

        public async Task<PropiedadDetalle> ObtenerPorIdAsync(Guid propiedadListadoId)
        {
            return await _context.PropiedadDetalleDBContext
                .FirstOrDefaultAsync(p => p.PropiedadListadoId == propiedadListadoId);
        }
    }
}
