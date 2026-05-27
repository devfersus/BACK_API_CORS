using COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Aplicacion.Dto;
using COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Aplicacion.Repository;
using COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Dominio.Interface;
using COREBAK.Usuario_.Entidad.Base;

namespace COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Aplicacion
{
    public class SDLoginUsuario
        (ILoginUsuario loginUsuario)
        : LoginUsuarioRepository
    {
        public readonly ILoginUsuario _loginUsuario = loginUsuario;

        public async Task<Usuario?> Login(LoginUsuarioDTO dto)
        {
            var usuario = await _loginUsuario.Login(dto.Usuario, dto.Contrasena);
            if (usuario == null) return null;

            // Si tiene token válido, lo devuelve tal cual (sin generar uno nuevo)
            if (usuario.Token != null && usuario.TokenExpiracion > DateTime.UtcNow)
                return usuario;

            // Si no tiene token o expiró, limpiamos para que el controller genere uno nuevo
            usuario.Token = null;
            return usuario;
        }

        public async Task GuardarToken(Guid usuarioId, string token, DateTime expiracion)
        {
            await _loginUsuario.GuardarToken(usuarioId, token, expiracion);
        }
    }
}
