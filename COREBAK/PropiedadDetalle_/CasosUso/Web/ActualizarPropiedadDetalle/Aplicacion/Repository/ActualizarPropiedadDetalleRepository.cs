using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Aplicacion.Dto;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Aplicacion.Repository
{
    public interface ActualizarPropiedadDetalleRepository
    {
        public Task ActualizarPropiedadDetalle(ActualizarPropiedadDetalleDTO actualizarPropiedadDetalleDTO);
    }
}