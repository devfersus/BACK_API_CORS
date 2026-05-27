using COREBAK.TipoListado_.Entidad.Base;

namespace COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Dominio.Interface
{
    public interface IActualizarTipoListado
    {
        public Task ActualizarTipoListado(TipoListado tipoListado);
    }
}
