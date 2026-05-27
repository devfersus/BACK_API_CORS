using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Aplicacion;
using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.CodigoPromocion.CasosUso.Web.ListarCodigoPromocion.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_CODIGO_PROMOCION)]
    [ApiController]
    public class ListarCodigoPromocionController : ControllerBase
    {
        private readonly SDListarCodigoPromocion ServicioAplicacion;

        public ListarCodigoPromocionController(SDListarCodigoPromocion servicioAplicacion)
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.LISTAR_CODIGO_PROMOCION)]
        public async Task<ActionResult> ListarCodigoPromocion([FromBody] ListarCodigoPromocionDTO request)
        {
            var data = await ServicioAplicacion.ListarCodigoPromocion(request.NumeroPagina, request.TamanioPagina);
            return Ok(data);
        }
    }
}
