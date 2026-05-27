using COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Aplicacion.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.PropiedadDetalle.CasosUso.Web.ActivarDesactivarFoto.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_PROPIEDAD_DETALLE)]
    [ApiController]
    public class ActivarDesactivarFotoController : ControllerBase
    {
        private readonly SDActivarDesactivarFoto ServicioAplicacion;

        public ActivarDesactivarFotoController(SDActivarDesactivarFoto servicioAplicacion)
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPut]
        [Route(Ruta.Ruta.ACTIVAR_DESACTIVAR_FOTO)]
        public async Task<ActionResult> ActivarDesactivarFoto([FromBody] ActivarDesactivarFotoDTO request)
        {
            await ServicioAplicacion.ActivarDesactivarFoto(request);
            return Ok();
        }
    }
}
