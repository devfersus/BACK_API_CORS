using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Aplicacion.Dto;
using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Aplicacion.Repository;
using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Dominio.Interface;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Aplicacion
{
    public class SDListarCodigoPromocion
        (IListarCodigoPromocion listarCodigoPromocion)
        : ListarCodigoPromocionRepository
    {
        private readonly IListarCodigoPromocion _listarCodigoPromocion = listarCodigoPromocion;

        public async Task<ListarCodigoPromocionPaginadoDTO> ListarCodigoPromocion(int numeroPagina, int tamanioPagina)
        {
            return await _listarCodigoPromocion.ListarCodigoPromocion(numeroPagina, tamanioPagina);
        }
    }
}
