using COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Aplicacion;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Aplicacion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoPropiedad.Shared.Web.ObtenerTipoPropiedadPorId.Controller
{
    [Authorize]
    [Route(RutaPrincipal.RutaPrincipal.RUTA_TIPO_PROPIEDAD)]
    [ApiController]
    public class ObtenerTipoPropiedadPorIdController : ControllerBase
    {
        public readonly SAObtenerTipoPropiedadPorId _servicio;

        public ObtenerTipoPropiedadPorIdController(SAObtenerTipoPropiedadPorId servicio)
        {
            _servicio = servicio;
        }

        [HttpGet(Ruta.Ruta.OBTENER_TIPO_PROPIEDAD)]
        public async Task<IActionResult> ObtenerPorId([FromQuery] Guid tipoPropiedadId)
        {
            var resultado = await _servicio.EjecutarAsync(tipoPropiedadId);
            return Ok(resultado);
        }
    }
}