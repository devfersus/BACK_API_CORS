using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Aplicacion.Dto;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Aplicacion.Repository
{
    public interface ListarCodigoPromocionRepository
    {
        Task<ListarCodigoPromocionPaginadoDTO> ListarCodigoPromocion(int numeroPagina, int tamanioPagina);
    }
}
