using COREBAK.Departamento_.Entidad.Base;

namespace COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Aplicacion.Dto
{
    public class ListarDepartamentoPaginadoDTO
    {
        public List<Departamento> Items { get; set; }
        public int TotalRegistros { get; set; }
        public int TotalPaginas { get; set; }
        public int NumeroPagina { get; set; }
        public int TamanioPagina { get; set; }
    }
}
