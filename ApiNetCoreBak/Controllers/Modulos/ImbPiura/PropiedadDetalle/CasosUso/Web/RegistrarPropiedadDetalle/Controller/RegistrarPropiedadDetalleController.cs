using COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.PropiedadDetalle.CasosUso.Web.RegistrarPropiedadDetalle.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_PROPIEDAD_DETALLE)]
    [ApiController]
    public class RegistrarPropiedadDetalleController : ControllerBase
    {
        private readonly SDRegistrarPropiedadDetalle ServicioAplicacion;

        public RegistrarPropiedadDetalleController(
            SDRegistrarPropiedadDetalle servicioAplicacion
            )
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.REGISTRAR_PROPIEDAD_DETALLE)]
        public async Task<ActionResult> ListarTipoListado([FromForm] RegistrarPropiedadDetalleDTO registrarTipoListado)
        {
            await ServicioAplicacion.RegistrarPropiedadDetalle(registrarTipoListado);
            //await Task.Delay(3000);
            return Ok();
        }
    }
}