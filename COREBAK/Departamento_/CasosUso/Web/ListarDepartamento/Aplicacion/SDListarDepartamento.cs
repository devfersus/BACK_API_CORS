using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Aplicacion.Dto;
using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Aplicacion.Repository;
using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Dominio.Interface;

namespace COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Aplicacion
{
    public class SDListarDepartamento(
        IListarDepartamento listarDepartamento
    ) : ListarDepartamentoRepository
    {
        public readonly IListarDepartamento _listarDepartamento = listarDepartamento;

        public async Task<ListarDepartamentoPaginadoDTO> ListarDepartamento(int numeroPagina, int tamanioPagina)
        {
            return await _listarDepartamento.ListarDepartamento(numeroPagina, tamanioPagina);
        }
    }
}
