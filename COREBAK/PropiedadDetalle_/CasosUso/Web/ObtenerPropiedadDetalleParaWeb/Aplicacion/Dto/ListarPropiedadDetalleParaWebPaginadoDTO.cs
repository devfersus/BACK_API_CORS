namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Aplicacion.Dto
{
    public class ListarPropiedadDetalleParaWebPaginadoDTO
    {
        public List<ObtenerPropiedadDetalleParaWebDTO> Items { get; set; }
        public int TotalRegistros { get; set; }
        public int TotalPaginas { get; set; }
        public int NumeroPagina { get; set; }
        public int TamanioPagina { get; set; }
    }
}
