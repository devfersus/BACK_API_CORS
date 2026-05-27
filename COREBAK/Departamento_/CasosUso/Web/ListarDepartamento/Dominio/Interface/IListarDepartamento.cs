using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Aplicacion.Dto;

namespace COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Dominio.Interface
{
    public interface IListarDepartamento
    {
        Task<ListarDepartamentoPaginadoDTO> ListarDepartamento(int numeroPagina, int tamanioPagina);
    }
}
