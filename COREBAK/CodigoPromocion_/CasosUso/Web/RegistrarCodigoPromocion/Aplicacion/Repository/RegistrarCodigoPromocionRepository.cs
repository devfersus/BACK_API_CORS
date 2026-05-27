using COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Aplicacion.Dto;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Aplicacion.Repository
{
    public interface RegistrarCodigoPromocionRepository
    {
        Task RegistrarCodigoPromocion(RegistrarCodigoPromocionDTO registrarCodigoPromocionDTO);
    }
}
