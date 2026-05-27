using COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Dominio.Interface;
using COREBAK.CodigoPromocion_.Entidad.Base;
using COREBAK.CodigoPromocion_.Entidad.DataBaseContext;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Infraestructura.Adaptador
{
    public class RegistrarCodigoPromocionAdapter : IRegistrarCodigoPromocion
    {
        private readonly CodigoPromocionDataBaseContext _context;

        public RegistrarCodigoPromocionAdapter(CodigoPromocionDataBaseContext context)
        {
            _context = context;
        }

        public async Task RegistrarCodigoPromocion(CodigoPromocion codigoPromocion)
        {
            _context.CodigoPromocionDBContext.Add(codigoPromocion);
            await _context.SaveChangesAsync();
        }
    }
}
