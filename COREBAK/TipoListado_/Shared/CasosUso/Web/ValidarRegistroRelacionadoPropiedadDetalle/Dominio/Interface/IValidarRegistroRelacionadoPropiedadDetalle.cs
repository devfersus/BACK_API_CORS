namespace COREBAK.TipoListado_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Dominio.Interface
{
    public interface IValidarRegistroRelacionadoPropiedadDetalle
    {
        Task<bool> ExisteActivoPorTipoListadoAsync(Guid tipoListadoId);
    }
}
