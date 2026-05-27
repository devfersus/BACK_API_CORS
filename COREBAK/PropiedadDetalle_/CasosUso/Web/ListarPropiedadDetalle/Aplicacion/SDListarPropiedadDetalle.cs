using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion.Dto;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion.Repository;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Dominio.Interface;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion
{
    public class SDListarPropiedadDetalle
        (IListarPropiedadDetalle listarPropiedadDetalle)
        : ListarPropiedadDetalleRepository
    {
        public readonly IListarPropiedadDetalle _listarPropiedadDetalle = listarPropiedadDetalle;

        public async Task<ListarPropiedadDetallePaginadoDTO> ListarPropiedadDetalle(int numeroPagina, int tamanioPagina)
        {
            return await _listarPropiedadDetalle.ListarPropiedadDetalle(numeroPagina, tamanioPagina);
        }
    }
}