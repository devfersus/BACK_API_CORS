using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Aplicacion.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.PropiedadDetalle.CasosUso.Web.ActualizarOrdenFoto.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_PROPIEDAD_DETALLE)]
    [ApiController]
    public class ActualizarOrdenFotoController : ControllerBase
    {
        private readonly SDActualizarOrdenFoto ServicioAplicacion;

        public ActualizarOrdenFotoController(SDActualizarOrdenFoto servicioAplicacion)
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPut]
        [Route(Ruta.Ruta.ACTUALIZAR_ORDEN_FOTO)]
        public async Task<ActionResult> ActualizarOrdenFoto([FromBody] ActualizarOrdenFotoDTO request)
        {
            await ServicioAplicacion.ActualizarOrdenFoto(request);
            return Ok();
        }
    }
}
