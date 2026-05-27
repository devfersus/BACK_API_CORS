using COREBAK.TipoPropiedad_.CasosUso.Web.ListarTipoPropiedad.Aplicacion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoPropiedad.CasosUso.Web.ListarTipoPropiedad.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_TIPO_PROPIEDAD)]
    [ApiController]
    public class ListarTipoPropiedadController : ControllerBase
    {
        private readonly SDListarTipoPropiedad ServicioAplicacion;

        public ListarTipoPropiedadController(
            SDListarTipoPropiedad servicioAplicacion
            )
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpGet]
        [Route(Ruta.Ruta.LISTAR_TIPO_PROPIEDAD)]
        public async Task<ActionResult> ListarTipoPropiedad()
        {
            var  tipoPropiedad = await ServicioAplicacion.ListarTipoPropiedad();
            //await Task.Delay(3000);
            return Ok(tipoPropiedad);
        }
    }
}