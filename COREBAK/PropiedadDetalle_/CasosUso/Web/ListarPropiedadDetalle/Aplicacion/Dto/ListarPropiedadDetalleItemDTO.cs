namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion.Dto
{
    public class ListarPropiedadDetalleItemDTO
    {
        public Guid PropiedadListadoId { get; set; }
        public Guid TipoPropiedadId { get; set; }
        public Guid TipoListadoId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public long ContadorClicks { get; set; }
        public int? CodigoPromocionId { get; set; }
        public bool Activo { get; set; }
        public int? DepartamentoId { get; set; }
        public string? DescripcionFinal { get; set; }
        public int? Orden { get; set; }
        public string? Ubicacion { get; set; }
        public string? AreaTerreno { get; set; }
        public string? TipoMoneda { get; set; }
        public List<PropiedadDetalleFotoDTO> Fotos { get; set; }
    }
}
