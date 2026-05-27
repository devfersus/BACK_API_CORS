using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Aplicacion.Dto;

namespace COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Aplicacion.Repository
{
    public interface ListarDepartamentoRepository
    {
        Task<ListarDepartamentoPaginadoDTO> ListarDepartamento(int numeroPagina, int tamanioPagina);
    }
}
