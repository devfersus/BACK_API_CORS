using COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Aplicacion.Dto;

namespace COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Aplicacion.Repository
{
    public interface ActualizarTipoListadoRepository
    {
        public Task ActualizarTipoListado(ActualizarTipoListadoDTO actualizarTipoListadoDTO);
    }
}
