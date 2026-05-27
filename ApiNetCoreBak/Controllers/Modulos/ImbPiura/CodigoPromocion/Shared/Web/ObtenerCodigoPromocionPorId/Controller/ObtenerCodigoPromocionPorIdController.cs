using COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Aplicacion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.CodigoPromocion.Shared.Web.ObtenerCodigoPromocionPorId.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_CODIGO_PROMOCION)]
    [ApiController]
    public class ObtenerCodigoPromocionPorIdController : ControllerBase
    {
        private readonly SAObtenerCodigoPromocionPorId _servicio;

        public ObtenerCodigoPromocionPorIdController(SAObtenerCodigoPromocionPorId servicio)
        {
            _servicio = servicio;
        }

        [HttpGet(Ruta.Ruta.OBTENER_CODIGO_PROMOCION)]
        public async Task<IActionResult> ObtenerPorId([FromQuery] int codigoPromocionId)
        {
            var resultado = await _servicio.EjecutarAsync(codigoPromocionId);
            return Ok(resultado);
        }
    }
}
