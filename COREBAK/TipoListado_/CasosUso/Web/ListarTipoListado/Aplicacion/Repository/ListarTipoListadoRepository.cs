using COREBAK.TipoListado_.Entidad.Base;

namespace COREBAK.TipoListado_.CasosUso.Web.ListarTipoListado.Aplicacion.Repository
{
    internal interface ListarTipoListadoRepository
    {
        public Task<List<TipoListado>> ListarTipoListado();
    }
}
