using COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Aplicacion.Dto;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Aplicacion.Repository
{
    public interface ActualizarTipoPropiedadRepository
    {
        public Task ActualizarTipoPropiedad(ActualizarTipoPropiedadDTO actualizarTipoPropiedadDTO);
    }
}
