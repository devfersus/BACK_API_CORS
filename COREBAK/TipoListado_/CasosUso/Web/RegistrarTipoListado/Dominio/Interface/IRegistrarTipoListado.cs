using COREBAK.TipoListado_.Entidad.Base;

namespace COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Dominio.Interface
{
    public interface IRegistrarTipoListado
    {
        Task registrarTipoListado(TipoListado tipoListado);
    }
}
