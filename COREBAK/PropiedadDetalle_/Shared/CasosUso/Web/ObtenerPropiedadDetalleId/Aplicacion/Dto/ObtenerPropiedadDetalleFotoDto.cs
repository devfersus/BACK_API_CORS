namespace COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ObtenerPropiedadDetalleId.Aplicacion.Dto
{
    public class ObtenerPropiedadDetalleFotoDto
    {
        public Guid PropiedadDetalleFotosId { get; set; }
        public string? Foto { get; set; }
        public bool? Activo { get; set; }
        public int? Orden { get; set; }
    }
}
