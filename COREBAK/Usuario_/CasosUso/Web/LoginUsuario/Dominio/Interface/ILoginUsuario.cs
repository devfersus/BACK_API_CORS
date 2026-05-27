using COREBAK.Usuario_.Entidad.Base;

namespace COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Dominio.Interface
{
    public interface ILoginUsuario
    {
        Task<Usuario?> Login(string usuario, string contrasena);
        Task GuardarToken(Guid usuarioId, string token, DateTime expiracion);
    }
}
