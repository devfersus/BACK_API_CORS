using COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Aplicacion;
using COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.CodigoPromocion.CasosUso.Web.ActualizarCodigoPromocion.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_CODIGO_PROMOCION)]
    [ApiController]
    public class ActualizarCodigoPromocionController : ControllerBase
    {
        private readonly SDActualizarCodigoPromocion ServicioAplicacion;

        public ActualizarCodigoPromocionController(SDActualizarCodigoPromocion servicioAplicacion)
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.ACTUALIZAR_CODIGO_PROMOCION)]
        public async Task<ActionResult> ActualizarCodigoPromocion([FromBody] ActualizarCodigoPromocionDTO request)
        {
            await ServicioAplicacion.ActualizarCodigoPromocion(request);
            return Ok();
        }
    }
}
