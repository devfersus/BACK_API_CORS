using COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Aplicacion;
using COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.Departamento.CasosUso.Web.RegistrarDepartamento.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_DEPARTAMENTO)]
    [ApiController]
    public class RegistrarDepartamentoController : ControllerBase
    {
        private readonly SDRegistrarDepartamento ServicioAplicacion;

        public RegistrarDepartamentoController(SDRegistrarDepartamento servicioAplicacion)
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.REGISTRAR_DEPARTAMENTO)]
        public async Task<ActionResult> Registrar([FromBody] RegistrarDepartamentoDTO dto)
        {
            await ServicioAplicacion.RegistrarDepartamento(dto);
            return Ok();
        }
    }
}
