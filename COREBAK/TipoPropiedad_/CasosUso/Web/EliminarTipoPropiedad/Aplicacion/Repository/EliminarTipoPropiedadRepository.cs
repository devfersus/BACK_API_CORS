using COREBAK.TipoPropiedad_.CasosUso.Web.EliminarTipoPropiedad.Aplicacion.Dto;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.EliminarTipoPropiedad.Aplicacion.Repository
{
    public interface EliminarTipoPropiedadRepository
    {
        public Task EliminarTipoPropiedad(EliminarTipoPropiedadDTO eliminarTipoPropiedad);
    }
}
