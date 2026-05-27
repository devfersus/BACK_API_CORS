using COREBAK.CodigoPromocion_.Entidad.Base;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Aplicacion.Dto
{
    public class ListarCodigoPromocionPaginadoDTO
    {
        public List<CodigoPromocion> Items { get; set; }
        public int TotalRegistros { get; set; }
        public int TotalPaginas { get; set; }
        public int NumeroPagina { get; set; }
        public int TamanioPagina { get; set; }
    }
}
