using COREBAK.PropiedadDetalle_.Entidad.Base;

namespace COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ObtenerPropiedadDetalleId.Dominio.Interface
{
    public interface IObtenerPropiedadDetallePorId
    {
        Task<PropiedadDetalle> ObtenerPorIdAsync(Guid propiedadListadoId);
    }
}