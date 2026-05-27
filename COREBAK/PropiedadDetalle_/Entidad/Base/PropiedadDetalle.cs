namespace COREBAK.PropiedadDetalle_.Entidad.Base
{
    public class PropiedadDetalle
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
        public List<PropiedadDetalleFoto> Fotos { get; set; } = new();

        public PropiedadDetalle(
             Guid propiedadListadoId
            , Guid tipoPropiedadId
            , Guid tipoListadoId
            , string titulo
            , string descripcion
            , decimal precio
            , long contadorClicks
            , int? codigoPromocionId
            , bool activo
            , int? departamentoId
            , string? descripcionFinal = null
            , int? orden = null
            , string? ubicacion = null
            , string? areaTerreno = null
            , string? tipoMoneda = null
            )
        {
            this.PropiedadListadoId = propiedadListadoId;
            this.TipoPropiedadId = tipoPropiedadId;
            this.TipoListadoId = tipoListadoId;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.ContadorClicks = contadorClicks;
            this.CodigoPromocionId = codigoPromocionId;
            this.Activo = activo;
            this.DepartamentoId = departamentoId;
            this.DescripcionFinal = descripcionFinal;
            this.Orden = orden;
            this.Ubicacion = ubicacion;
            this.AreaTerreno = areaTerreno;
            this.TipoMoneda = tipoMoneda;
        }

        // Constructor parcial - Actualizar
        public PropiedadDetalle(
             Guid propiedadListadoId
            , Guid tipoPropiedadId
            , Guid tipoListadoId
            , string titulo
            , string descripcion
            , decimal precio
            , int? codigoPromocionId
            , bool activo
            , int? departamentoId
            , string? descripcionFinal = null
            , int? orden = null
            , string? ubicacion = null
            , string? areaTerreno = null
            , string? tipoMoneda = null
            )
        {
            this.PropiedadListadoId = propiedadListadoId;
            this.TipoPropiedadId = tipoPropiedadId;
            this.TipoListadoId = tipoListadoId;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.CodigoPromocionId = codigoPromocionId;
            this.Activo = activo;
            this.DepartamentoId = departamentoId;
            this.DescripcionFinal = descripcionFinal;
            this.Orden = orden;
            this.Ubicacion = ubicacion;
            this.AreaTerreno = areaTerreno;
            this.TipoMoneda = tipoMoneda;
        }

        public void actualizarPropiedadDetalle(
             Guid tipoPropiedadId
            , Guid tipoListadoId
            , string titulo
            , string descripcion
            , decimal precio
            , int? codigoPromocionId
            , bool activo
            , int? departamentoId
            , string? descripcionFinal = null
            , int? orden = null
            , string? ubicacion = null
            , string? areaTerreno = null
            , string? tipoMoneda = null
            )
        {
            this.TipoPropiedadId = tipoPropiedadId;
            this.TipoListadoId = tipoListadoId;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.CodigoPromocionId = codigoPromocionId;
            this.Activo = activo;
            this.DepartamentoId = departamentoId;
            this.DescripcionFinal = descripcionFinal;
            this.Orden = orden;
            this.Ubicacion = ubicacion;
            this.AreaTerreno = areaTerreno;
            this.TipoMoneda = tipoMoneda;
        }
    }
}
