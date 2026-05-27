using COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Aplicacion.Dto;
using COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Aplicacion.Repository;
using COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Dominio.Interface;
using COREBAK.Departamento_.Entidad.Base;

namespace COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Aplicacion
{
    public class SDActualizarDepartamento(
        IActualizarDepartamento actualizarDepartamento
    ) : ActualizarDepartamentoRepository
    {
        public readonly IActualizarDepartamento _actualizarDepartamento = actualizarDepartamento;

        public async Task ActualizarDepartamento(ActualizarDepartamentoDTO actualizarDepartamentoDTO)
        {
            Departamento departamento = new Departamento(
                actualizarDepartamentoDTO.DepartamentoId,
                actualizarDepartamentoDTO.Descripcion,
                actualizarDepartamentoDTO.Activo
            );
            await _actualizarDepartamento.ActualizarDepartamento(departamento);
        }
    }
}
