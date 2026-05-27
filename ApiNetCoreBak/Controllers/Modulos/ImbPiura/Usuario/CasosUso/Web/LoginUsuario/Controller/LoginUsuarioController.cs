using ApiNetCoreBak.Controllers.Modulos.JWT.IJwtTokenService_;
using COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Aplicacion;
using COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.Usuario.CasosUso.Web.LoginUsuario.Controller
{
    [ApiController]
    [Route("api/usuario")]
    public class LoginUsuarioController : ControllerBase
    {
        private readonly SDLoginUsuario _sdLoginUsuario;
        private readonly IJwtTokenService _jwtTokenService;

        public LoginUsuarioController(SDLoginUsuario sdLoginUsuario, IJwtTokenService jwtTokenService)
        {
            _sdLoginUsuario = sdLoginUsuario;
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUsuarioDTO dto)
        {
            var usuario = await _sdLoginUsuario.Login(dto);

            if (usuario == null)
                return Unauthorized(new { message = "Usuario o contraseña incorrectos" });

            // Si ya tiene token válido, lo reutiliza
            if (usuario.Token != null)
                return Ok(new { token = usuario.Token });

            // Si no tiene token o expiró, genera uno nuevo y lo guarda
            var nuevoToken = _jwtTokenService.GenerateToken(
                userId: usuario.UsuarioId.ToString(),
                email: usuario.NombreUsuario,
                roles: new List<string> { "User" }
            );

            var expiracion = DateTime.UtcNow.AddMinutes(1440);
            await _sdLoginUsuario.GuardarToken(usuario.UsuarioId, nuevoToken, expiracion);

            return Ok(new { token = nuevoToken });
        }
    }
}
