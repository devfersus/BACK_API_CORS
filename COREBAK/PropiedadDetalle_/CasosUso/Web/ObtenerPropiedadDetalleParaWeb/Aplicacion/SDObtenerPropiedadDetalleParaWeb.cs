using COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Aplicacion.Dto;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Dominio.Interface;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Aplicacion
{
    public class SDObtenerPropiedadDetalleParaWeb
        (IObtenerPropiedadDetalleParaWeb obtener)
    {
        private readonly IObtenerPropiedadDetalleParaWeb _obtener = obtener;

        public async Task<ListarPropiedadDetalleParaWebPaginadoDTO> ListarAsync(int numeroPagina, int tamanioPagina)
        {
            return await _obtener.ListarAsync(numeroPagina, tamanioPagina);
        }
    }
}
