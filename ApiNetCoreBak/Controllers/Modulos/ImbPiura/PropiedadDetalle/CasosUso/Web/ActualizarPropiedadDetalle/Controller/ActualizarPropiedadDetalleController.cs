using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.PropiedadDetalle.CasosUso.Web.ActualizarPropiedadDetalle.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_PROPIEDAD_DETALLE)]
    [ApiController]
    public class ActualizarPropiedadDetalleController : ControllerBase
    {
        private readonly SDActualizarPropiedadDetalle ServicioAplicacion;

        public ActualizarPropiedadDetalleController(
            SDActualizarPropiedadDetalle servicioAplicacion
            )
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.ACTUALIZAR_PROPIEDAD_DETALLE)]
        public async Task<ActionResult> ListarTipoListado([FromBody] ActualizarPropiedadDetalleDTO actualizarPropiedadDetalle)
        {
            await ServicioAplicacion.ActualizarPropiedadDetalle(actualizarPropiedadDetalle);
            //await Task.Delay(3000);
            return Ok();
        }
    }
}