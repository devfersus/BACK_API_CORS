using COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Aplicacion;
using COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoListado.CasosUso.Web.RegistrarTipoListado.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_TIPO_LISTADO)]
    [ApiController]
    public class RegistrarTipoListadoController : ControllerBase
    {
        private readonly SDTipoListadoRegistrar ServicioAplicacion;

        public RegistrarTipoListadoController(
            SDTipoListadoRegistrar servicioAplicacion
            )
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.REGISTRAR_TIPO_LISTADO)]
        public async Task<ActionResult> ListarTipoListado([FromBody] RegistrarTipoListadoDTO registrarTipoListado)
        {
            await ServicioAplicacion.registrarTipoListado(registrarTipoListado);
            //await Task.Delay(3000);
            return Ok();
        }
    }
}