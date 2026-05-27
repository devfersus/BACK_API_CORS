using COREBAK.CodigoPromocion_.Entidad.Base;
using COREBAK.CodigoPromocion_.Entidad.DataBaseContext;
using COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Dominio.Interface;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Infraestructura.Adaptador
{
    public class ObtenerCodigoPromocionPorIdAdapter : IObtenerCodigoPromocionPorId
    {
        private readonly CodigoPromocionDataBaseContext _context;

        public ObtenerCodigoPromocionPorIdAdapter(CodigoPromocionDataBaseContext context)
        {
            _context = context;
        }

        public async Task<CodigoPromocion?> ObtenerPorIdAsync(int codigoPromocionId)
        {
            return await _context.CodigoPromocionDBContext
                .FirstOrDefaultAsync(x => x.CodigoPromocionId == codigoPromocionId);
        }
    }
}
