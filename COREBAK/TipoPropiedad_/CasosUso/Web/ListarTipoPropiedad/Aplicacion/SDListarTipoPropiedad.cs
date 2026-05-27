using COREBAK.TipoPropiedad_.CasosUso.Web.ListarTipoPropiedad.Aplicacion.Repository;
using COREBAK.TipoPropiedad_.CasosUso.Web.ListarTipoPropiedad.Dominio.Interface;
using COREBAK.TipoPropiedad_.Entidad.Base;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.ListarTipoPropiedad.Aplicacion
{
    public class SDListarTipoPropiedad
        (IListarTipoPropiedad listarTipoPropiedad)
        : ListarTipoPropiedadRepository
    {
        public readonly IListarTipoPropiedad TipoPropiedad = listarTipoPropiedad;
        public async Task<List<TipoPropiedad>> ListarTipoPropiedad()
        {
            return await TipoPropiedad.ListarTipoPropiedad();
        }
    }
}
