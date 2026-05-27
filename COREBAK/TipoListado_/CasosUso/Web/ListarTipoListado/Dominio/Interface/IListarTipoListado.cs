using COREBAK.TipoListado_.Entidad.Base;

namespace COREBAK.TipoListado_.CasosUso.Web.ListarTipoListado.Dominio.Interface
{
    public interface IListarTipoListado
    {
        public Task<List<TipoListado>> ListarTipoListado();
    }
}