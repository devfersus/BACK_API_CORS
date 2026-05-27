using COREBAK.TipoListado_.Entidad.Base;

namespace COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Dominio.Interface
{
    public interface IObtenerTipoListadoPorIdRepository
    {
        public Task<TipoListado> ObtenerPorIdAsync(Guid tipoListadoId);
    }
}
