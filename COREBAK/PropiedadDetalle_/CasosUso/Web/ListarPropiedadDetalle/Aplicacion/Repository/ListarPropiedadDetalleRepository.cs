using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion.Dto;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion.Repository
{
    public interface ListarPropiedadDetalleRepository
    {
        public Task<ListarPropiedadDetallePaginadoDTO> ListarPropiedadDetalle(int numeroPagina, int tamanioPagina);
    }
}
