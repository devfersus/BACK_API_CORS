using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Aplicacion;
using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.Departamento.CasosUso.Web.ListarDepartamento.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_DEPARTAMENTO)]
    [ApiController]
    public class ListarDepartamentoController : ControllerBase
    {
        private readonly SDListarDepartamento ServicioAplicacion;

        public ListarDepartamentoController(SDListarDepartamento servicioAplicacion)
        {
            ServicioAplicacion = servicioAplicacion;
        }

        [HttpPost]
        [Route(Ruta.Ruta.LISTAR_DEPARTAMENTO)]
        public async Task<ActionResult> Listar([FromBody] ListarDepartamentoDTO request)
        {
            var data = await ServicioAplicacion.ListarDepartamento(request.NumeroPagina, request.TamanioPagina);
            return Ok(data);
        }
    }
}
