namespace COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Dominio.Interface
{
    public interface IValidarRegistroRelacionadoPropiedadDetalle
    {
        Task<bool> ExisteActivoPorTipoPropiedadAsync(Guid tipoPropiedadId);
    }
}
