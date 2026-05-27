using COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Aplicacion.Dto;

namespace COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Aplicacion.Repository
{
    internal interface RegistrarTipoListadoRepository
    {
        Task registrarTipoListado(RegistrarTipoListadoDTO registrarTipoListadoDTO);
    }
}
