using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.PropiedadDetalle.CasosUso.Web.ListarPropiedadDetalle.Controller
{
    [Route(RutaPrincipal.RutaPrincipal.RUTA_PROPIEDAD_DETALLE)]
    [ApiController]
    public class ListarPropiedadDetalleController : ControllerBase
    {
        private readonly SDListarPropiedadDetalle ServicioAplicacion;

        public ListarPropiedadDetalleController(
            SDListarPropiedadDetalle servicioAplicacion
            )
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.LISTAR_PROPIEDAD_DETALLE)]
        public async Task<ActionResult> ListarTipoListado([FromBody] ListarPropiedadDetalleDTO request)
        {
            var data = await ServicioAplicacion.ListarPropiedadDetalle(request.NumeroPagina, request.TamanioPagina);
            //await Task.Delay(3000);
            return Ok(data);
        }
    }
}