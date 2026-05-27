using COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Dominio.Interface;
using COREBAK.Usuario_.Entidad.Base;
using COREBAK.Usuario_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Infraestructura.Adaptador
{
    public class LoginUsuarioAdapter : ILoginUsuario
    {
        public readonly UsuarioDataBaseContext _context;

        public LoginUsuarioAdapter(UsuarioDataBaseContext context)
        {
            _context = context;
        }

        public async Task<Usuario?> Login(string usuario, string contrasena)
        {
            return await _context.UsuarioDBContext
                .Where(u => u.NombreUsuario == usuario && u.Contrasena == contrasena && u.Activo)
                .FirstOrDefaultAsync();
        }

        public async Task GuardarToken(Guid usuarioId, string token, DateTime expiracion)
        {
            var usuario = await _context.UsuarioDBContext.FindAsync(usuarioId);
            if (usuario != null)
            {
                usuario.Token = token;
                usuario.TokenExpiracion = expiracion;
                await _context.SaveChangesAsync();
            }
        }
    }
}
