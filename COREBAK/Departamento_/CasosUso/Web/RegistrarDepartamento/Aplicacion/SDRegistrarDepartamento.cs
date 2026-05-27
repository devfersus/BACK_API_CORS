using COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Aplicacion.Dto;
using COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Aplicacion.Repository;
using COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Dominio.Interface;
using COREBAK.Departamento_.Entidad.Base;

namespace COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Aplicacion
{
    public class SDRegistrarDepartamento(
        IRegistrarDepartamento registrarDepartamento
    ) : RegistrarDepartamentoRepository
    {
        public readonly IRegistrarDepartamento _registrarDepartamento = registrarDepartamento;

        public async Task RegistrarDepartamento(RegistrarDepartamentoDTO registrarDepartamentoDTO)
        {
            Departamento departamento = new Departamento(
                registrarDepartamentoDTO.DepartamentoId,
                registrarDepartamentoDTO.Descripcion,
                registrarDepartamentoDTO.Activo = true
            );
            await _registrarDepartamento.RegistrarDepartamento(departamento);
        }
    }
}
