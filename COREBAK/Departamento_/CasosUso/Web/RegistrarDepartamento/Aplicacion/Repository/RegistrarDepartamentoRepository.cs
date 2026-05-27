using COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Aplicacion.Dto;

namespace COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Aplicacion.Repository
{
    public interface RegistrarDepartamentoRepository
    {
        public Task RegistrarDepartamento(RegistrarDepartamentoDTO registrarDepartamentoDTO);
    }
}
