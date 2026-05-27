namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Dominio.Interface
{
    public interface IActualizarOrdenFoto
    {
        Task ActualizarOrdenFoto(Guid propiedadDetalleFotosId, int orden);
    }
}
