using COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Aplicacion.Dto;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Aplicacion.Repository
{
    public interface RegistrarTipoPropiedadRepository
    {
        public Task RegistrarTipoPropiedad(RegistrarTipoPropiedadDTO tipoPropiedadDTO);
    }
}
