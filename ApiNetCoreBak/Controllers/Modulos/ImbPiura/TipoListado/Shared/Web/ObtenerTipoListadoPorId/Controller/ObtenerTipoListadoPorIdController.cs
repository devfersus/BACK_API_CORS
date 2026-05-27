using COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Aplicacion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoListado.Shared.Web.ObtenerTipoListadoPorId.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_TIPO_LISTADO)]
    [ApiController]
    public class ObtenerTipoListadoPorIdController : ControllerBase
    {
        public readonly SDObtenerTipoListadoPorId _servicio;

        public ObtenerTipoListadoPorIdController(SDObtenerTipoListadoPorId servicio)
        {
            _servicio = servicio;
        }

        [HttpGet(Ruta.Ruta.OBTENER_TIPO_LISTADO)]
        public async Task<IActionResult> ObtenerPorId([FromQuery] Guid tipoListadoId)
        {
            var resultado = await _servicio.EjecutarAsync(tipoListadoId);
            return Ok(resultado);
        }
    }
}