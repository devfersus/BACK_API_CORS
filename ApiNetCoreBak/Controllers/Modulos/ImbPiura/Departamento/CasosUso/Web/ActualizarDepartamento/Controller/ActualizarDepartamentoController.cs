using COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Aplicacion;
using COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.Departamento.CasosUso.Web.ActualizarDepartamento.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_DEPARTAMENTO)]
    [ApiController]
    public class ActualizarDepartamentoController : ControllerBase
    {
        private readonly SDActualizarDepartamento ServicioAplicacion;

        public ActualizarDepartamentoController(SDActualizarDepartamento servicioAplicacion)
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.ACTUALIZAR_DEPARTAMENTO)]
        public async Task<ActionResult> Actualizar([FromBody] ActualizarDepartamentoDTO dto)
        {
            await ServicioAplicacion.ActualizarDepartamento(dto);
            return Ok();
        }
    }
}
