using COREBAK.Departamento_.Shared.CasosUso.Web.ObtenerDepartamentoPorId.Aplicacion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.Departamento.Shared.Web.ObtenerDepartamentoPorId.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_DEPARTAMENTO)]
    [ApiController]
    public class ObtenerDepartamentoPorIdController : ControllerBase
    {
        private readonly SAObtenerDepartamentoPorId _servicio;

        public ObtenerDepartamentoPorIdController(SAObtenerDepartamentoPorId servicio)
        {
            _servicio = servicio;
        }

        [HttpGet(Ruta.Ruta.OBTENER_DEPARTAMENTO)]
        public async Task<IActionResult> ObtenerPorId([FromQuery] int departamentoId)
        {
            var resultado = await _servicio.EjecutarAsync(departamentoId);
            return Ok(resultado);
        }
    }
}
