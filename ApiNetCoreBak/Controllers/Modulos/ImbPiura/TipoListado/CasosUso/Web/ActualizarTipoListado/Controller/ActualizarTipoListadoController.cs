using COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Aplicacion;
using COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoListado.CasosUso.Web.ActualizarTipoListado.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_TIPO_LISTADO)]
    [ApiController]
    public class ActualizarTipoListadoController : ControllerBase
    {
        private readonly SDTipoListadoActualizar ServicioAplicacion;

        public ActualizarTipoListadoController(
            SDTipoListadoActualizar servicioAplicacion
            )
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.ACTUALIZAR_TIPO_LISTADO)]
        public async Task<ActionResult> ListarTipoListado([FromBody] ActualizarTipoListadoDTO actualizarTipoListadoDTO)
        {
            await ServicioAplicacion.ActualizarTipoListado(actualizarTipoListadoDTO);
            //await Task.Delay(3000);
            return Ok();
        }
    }
}