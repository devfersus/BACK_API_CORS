namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Aplicacion.Dto
{
    public class ObtenerPropiedadDetalleParaWebDTO
    {
        public Guid PropiedadListadoId { get; set; }
        public Guid TipoPropiedadId { get; set; }
        public string? DescripcionTipoPropiedad { get; set; }
        public Guid TipoListadoId { get; set; }
        public string? DescripcionTipoListado { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public long ContadorClicks { get; set; }
        public int? CodigoPromocionId { get; set; }
        public string? DescripcionPromocion { get; set; }
        public bool Activo { get; set; }
        public int? DepartamentoId { get; set; }
        public string? DescripcionDepartamento { get; set; }
        public string? DescripcionFinal { get; set; }
        public int? Orden { get; set; }
        public string? Ubicacion { get; set; }
        public string? AreaTerreno { get; set; }
        public string? TipoMoneda { get; set; }
        public List<ObtenerPropiedadDetalleParaWebFotoDTO> Fotos { get; set; } = new();
    }
}
