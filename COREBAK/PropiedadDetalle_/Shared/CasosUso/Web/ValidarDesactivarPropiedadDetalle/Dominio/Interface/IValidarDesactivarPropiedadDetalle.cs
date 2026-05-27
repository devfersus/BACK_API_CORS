using COREBAK.PropiedadDetalle_.Entidad.Base;

namespace COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ValidarDesactivarPropiedadDetalle.Dominio.Interface
{
    public interface IValidarDesactivarPropiedadDetalle
    {
        Task<PropiedadDetalle> ObtenerPorIdAsync(Guid propiedadListadoId);
    }
}
