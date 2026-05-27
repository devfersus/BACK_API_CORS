namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion.Dto
{
    public class PropiedadDetalleFotoDTO
    {
        public Guid PropiedadDetalleFotosId { get; set; }
        public string? Foto { get; set; }
        public bool? Activo { get; set; }
        public int? Orden { get; set; }
    }
}
