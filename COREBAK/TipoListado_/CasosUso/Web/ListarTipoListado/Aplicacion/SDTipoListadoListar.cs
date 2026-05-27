using COREBAK.TipoListado_.CasosUso.Web.ListarTipoListado.Aplicacion.Repository;
using COREBAK.TipoListado_.CasosUso.Web.ListarTipoListado.Dominio.Interface;
using COREBAK.TipoListado_.Entidad.Base;

namespace COREBAK.TipoListado_.CasosUso.Web.ListarTipoListado.Aplicacion
{
    public class SDTipoListadoListar
        (IListarTipoListado listarTipoListado)
        : ListarTipoListadoRepository
    {
        public readonly IListarTipoListado _listarTipoListado = listarTipoListado;

        public async Task<List<TipoListado>> ListarTipoListado()
        {
            return await _listarTipoListado.ListarTipoListado();
        }
    }
}