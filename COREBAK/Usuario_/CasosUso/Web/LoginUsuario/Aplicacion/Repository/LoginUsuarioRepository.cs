using COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Aplicacion.Dto;
using COREBAK.Usuario_.Entidad.Base;

namespace COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Aplicacion.Repository
{
    internal interface LoginUsuarioRepository
    {
        Task<Usuario?> Login(LoginUsuarioDTO dto);
    }
}
