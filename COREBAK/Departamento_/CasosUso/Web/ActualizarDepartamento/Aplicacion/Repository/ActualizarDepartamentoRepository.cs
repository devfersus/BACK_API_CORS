using COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Aplicacion.Dto;

namespace COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Aplicacion.Repository
{
    public interface ActualizarDepartamentoRepository
    {
        public Task ActualizarDepartamento(ActualizarDepartamentoDTO actualizarDepartamentoDTO);
    }
}
