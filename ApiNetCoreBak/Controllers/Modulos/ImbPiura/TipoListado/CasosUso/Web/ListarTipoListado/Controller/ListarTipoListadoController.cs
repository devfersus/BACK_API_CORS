using COREBAK.TipoListado_.CasosUso.Web.ListarTipoListado.Aplicacion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoListado.CasosUso.Web.ListarTipoListado.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_TIPO_LISTADO)]
    [ApiController]
    public class ListarTipoListadoController : ControllerBase
    {
        private readonly SDTipoListadoListar ServicioAplicacion;

        public ListarTipoListadoController(
            SDTipoListadoListar servicioAplicacion
            )
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpGet]
        [Route(Ruta.Ruta.LISTAR_TIPO_LISTADO)]
        public async Task<ActionResult> ListarTipoListado()
        {
            var tipoListado = await ServicioAplicacion.ListarTipoListado();
            //await Task.Delay(3000);
            return Ok(tipoListado);
        }
    }
}