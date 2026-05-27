namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Dominio.Interface
{
    public interface IActivarDesactivarFoto
    {
        Task ActivarDesactivarFoto(Guid propiedadDetalleFotosId, bool activo);
    }
}
