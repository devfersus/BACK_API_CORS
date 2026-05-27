using COREBAK.TipoPropiedad_.CasosUso.Web.EliminarTipoPropiedad.Aplicacion;
using COREBAK.TipoPropiedad_.CasosUso.Web.EliminarTipoPropiedad.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoPropiedad.CasosUso.Web.EliminarTipoPropiedad.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_TIPO_PROPIEDAD)]
    [ApiController]
    public class EliminarTipoPropiedadController : ControllerBase
    {
        private readonly ServicioAplicacion ServicioAplicacion;

        public EliminarTipoPropiedadController(
            ServicioAplicacion servicioAplicacion
            )
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.ELIMINAR_TIPO_PROPIEDAD)]
        public async Task<ActionResult> Registrar([FromQuery] EliminarTipoPropiedadDTO eliminarTipoPropiedad)
        {
            await ServicioAplicacion.EliminarTipoPropiedad(eliminarTipoPropiedad);
            //await Task.Delay(3000);
            return Ok();
        }
    }
}
