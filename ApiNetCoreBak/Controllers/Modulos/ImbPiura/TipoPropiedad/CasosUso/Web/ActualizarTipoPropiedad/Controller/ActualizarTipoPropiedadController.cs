using COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Aplicacion;
using COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoPropiedad.CasosUso.Web.ActualizarTipoPropiedad.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_TIPO_PROPIEDAD)]
    [ApiController]
    public class ActualizarTipoPropiedadController : ControllerBase
    {
        private readonly ServicioAplicacion ServicioAplicacion;

        public ActualizarTipoPropiedadController(
            ServicioAplicacion servicioAplicacion
            )
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.ACTUALIZAR_TIPO_PROPIEDAD)]
        public async Task<ActionResult> Registrar([FromBody] ActualizarTipoPropiedadDTO actualizarTipoPropiedad)
        {
            await ServicioAplicacion.ActualizarTipoPropiedad(actualizarTipoPropiedad);
            //await Task.Delay(3000);
            return Ok();
        }
    }
}
