using COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Aplicacion.Dto;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Aplicacion.Repository
{
    public interface ActualizarCodigoPromocionRepository
    {
        Task ActualizarCodigoPromocion(ActualizarCodigoPromocionDTO actualizarCodigoPromocionDTO);
    }
}
