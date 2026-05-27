using COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Aplicacion;
using COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.CodigoPromocion.CasosUso.Web.RegistrarCodigoPromocion.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_CODIGO_PROMOCION)]
    [ApiController]
    public class RegistrarCodigoPromocionController : ControllerBase
    {
        private readonly SDRegistrarCodigoPromocion ServicioAplicacion;

        public RegistrarCodigoPromocionController(SDRegistrarCodigoPromocion servicioAplicacion)
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.REGISTRAR_CODIGO_PROMOCION)]
        public async Task<ActionResult> RegistrarCodigoPromocion([FromBody] RegistrarCodigoPromocionDTO request)
        {
            await ServicioAplicacion.RegistrarCodigoPromocion(request);
            return Ok();
        }
    }
}
