using COREBAK.CodigoPromocion_.Entidad.Base;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Dominio.Interface
{
    public interface IActualizarCodigoPromocion
    {
        Task ActualizarCodigoPromocion(CodigoPromocion codigoPromocion);
    }
}
