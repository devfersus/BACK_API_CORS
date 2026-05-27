using COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.PropiedadDetalle.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Controller
{
    [ApiController]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_PROPIEDAD_DETALLE)]
    public class ObtenerPropiedadDetalleParaWebController : ControllerBase
    {
        private readonly SDObtenerPropiedadDetalleParaWeb ServicioAplicacion;

        public ObtenerPropiedadDetalleParaWebController(SDObtenerPropiedadDetalleParaWeb servicioAplicacion)
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.OBTENER_PROPIEDAD_DETALLE_PARA_WEB)]
        public async Task<IActionResult> ListarParaWeb([FromBody] ListarPropiedadDetalleParaWebDTO request)
        {
            var data = await ServicioAplicacion.ListarAsync(request.NumeroPagina, request.TamanioPagina);
            return Ok(data);
        }
    }
}
