namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Aplicacion.Dto
{
    public class ObtenerPropiedadDetalleParaWebFotoDTO
    {
        public Guid PropiedadDetalleFotosId { get; set; }
        public string? Foto { get; set; }
        public bool? Activo { get; set; }
        public int? Orden { get; set; }
    }
}
