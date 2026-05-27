using COREBAK.CodigoPromocion_.Entidad.Base;

namespace COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Dominio.Interface
{
    public interface IObtenerCodigoPromocionPorId
    {
        Task<CodigoPromocion?> ObtenerPorIdAsync(int codigoPromocionId);
    }
}
