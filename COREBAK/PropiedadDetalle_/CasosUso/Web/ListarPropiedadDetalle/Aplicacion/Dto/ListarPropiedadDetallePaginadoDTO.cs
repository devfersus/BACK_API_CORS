namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion.Dto
{
    public class ListarPropiedadDetallePaginadoDTO
    {
        public List<ListarPropiedadDetalleItemDTO> Items { get; set; }
        public int TotalRegistros { get; set; }
        public int TotalPaginas { get; set; }
        public int NumeroPagina { get; set; }
        public int TamanioPagina { get; set; }
    }
}
