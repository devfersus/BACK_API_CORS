using COREBAK.CodigoPromocion_.Entidad.Base;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Dominio.Interface
{
    public interface IRegistrarCodigoPromocion
    {
        Task RegistrarCodigoPromocion(CodigoPromocion codigoPromocion);
    }
}
