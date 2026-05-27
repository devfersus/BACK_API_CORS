using COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Aplicacion;
using COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoPropiedad.CasosUso.Web.RegistrarTipoProiedad.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_TIPO_PROPIEDAD)]
    [ApiController]
    public class RegistrarTipoProiedadController : ControllerBase
    {
        private readonly SDRegistaraTipoPropiedad ServicioAplicacion;

        public RegistrarTipoProiedadController(
            SDRegistaraTipoPropiedad servicioAplicacion
            )
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.REGISTRAR_TIPO_PROPIEDAD)]
        public async Task<ActionResult> Registrar([FromBody] RegistrarTipoPropiedadDTO dto)
        {
            await ServicioAplicacion.RegistrarTipoPropiedad(dto);
            //await Task.Delay(3000);
            return Ok();
        }
    }
}