using COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Aplicacion.Dto;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Dominio.Interface
{
    public interface IObtenerPropiedadDetalleParaWeb
    {
        Task<ListarPropiedadDetalleParaWebPaginadoDTO> ListarAsync(int numeroPagina, int tamanioPagina);
    }
}
