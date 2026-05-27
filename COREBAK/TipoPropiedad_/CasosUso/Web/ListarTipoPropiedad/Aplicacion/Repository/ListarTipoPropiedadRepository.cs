using COREBAK.TipoPropiedad_.Entidad.Base;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.ListarTipoPropiedad.Aplicacion.Repository
{
    public interface ListarTipoPropiedadRepository
    {
        public Task<List<TipoPropiedad>> ListarTipoPropiedad();
    }
}
