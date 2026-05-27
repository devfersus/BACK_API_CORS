using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Aplicacion.Dto;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Dominio.Interface
{
    public interface IListarCodigoPromocion
    {
        Task<ListarCodigoPromocionPaginadoDTO> ListarCodigoPromocion(int numeroPagina, int tamanioPagina);
    }
}
