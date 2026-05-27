using COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ObtenerPropiedadDetalleId.Aplicacion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.PropiedadDetalle.Shared.ObtenerPropiedadDetallePorId.Controller
{
    [ApiController]
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_PROPIEDAD_DETALLE)]
    public class ObtenerPropiedadDetallePorIdController : ControllerBase
    {
        private readonly SAObtenerPropiedadDetallePorId _servicio;

        public ObtenerPropiedadDetallePorIdController(SAObtenerPropiedadDetallePorId servicio)
        {
            _servicio = servicio;
        }

        [HttpGet(Ruta.Ruta.OBTENER_PROPIEDAD_DETALLE)]
        public async Task<IActionResult> ObtenerPorId([FromQuery] Guid propiedadListadoId)
        {
            var resultado = await _servicio.EjecutarAsync(propiedadListadoId);
            return Ok(resultado);
        }
    }
}