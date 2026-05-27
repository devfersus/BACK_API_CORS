namespace COREBAK.PropiedadDetalle_.Entidad.Base
{
    public class PropiedadDetalleFoto
    {
        public Guid PropiedadDetalleFotos { get; set; }
        public Guid? PropiedadListadoId { get; set; }
        public string? Foto { get; set; }
        public bool? Activo { get; set; }
        public int? Orden { get; set; }
    }
}
