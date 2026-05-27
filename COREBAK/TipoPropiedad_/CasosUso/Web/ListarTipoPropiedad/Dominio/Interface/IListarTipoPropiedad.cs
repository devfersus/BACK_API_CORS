using COREBAK.TipoPropiedad_.Entidad.Base;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.ListarTipoPropiedad.Dominio.Interface
{
    public interface IListarTipoPropiedad
    {
        public Task<List<TipoPropiedad>>ListarTipoPropiedad();
    }
}