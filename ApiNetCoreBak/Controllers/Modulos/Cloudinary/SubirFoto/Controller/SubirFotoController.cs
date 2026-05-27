using COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Aplicacion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiNetCoreBak.Controllers.Modulos.Cloudinary.SubirFoto.Controller
{
    [Authorize]
    [Route("api/cloudinary")]
    [ApiController]
    public class SubirFotoController : ControllerBase
    {
        private readonly SDSubirFoto servicioAplicacion;

        public SubirFotoController(SDSubirFoto _servicioAplicacion)
        {
            servicioAplicacion = _servicioAplicacion;
        }

        [HttpPost("subirfoto")]
        public async Task<ActionResult> subirFoto(IFormFile foto)
        {
            var url = await servicioAplicacion.subirFoto(foto);
            return Ok(new { urlFoto = url });
        }
    }
}
