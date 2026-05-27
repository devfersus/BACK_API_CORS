using COREBAK.Departamento_.Shared.CasosUso.Web.ObtenerDepartamentoPorId.Aplicacion.Dto;
using COREBAK.Departamento_.Shared.CasosUso.Web.ObtenerDepartamentoPorId.Dominio.Interface;

namespace COREBAK.Departamento_.Shared.CasosUso.Web.ObtenerDepartamentoPorId.Aplicacion
{
    public class SAObtenerDepartamentoPorId
    {
        private readonly IObtenerDepartamentoPorId _repository;

        public SAObtenerDepartamentoPorId(IObtenerDepartamentoPorId repository)
        {
            _repository = repository;
        }

        public async Task<ObtenerDepartamentoPorIdDto> EjecutarAsync(int departamentoId)
        {
            var departamento = await _repository.ObtenerPorIdAsync(departamentoId);

            if (departamento == null)
                throw new Exception($"Departamento con Id {departamentoId} no encontrado.");

            return new ObtenerDepartamentoPorIdDto
            {
                DepartamentoId = departamento.DepartamentoId,
                Descripcion    = departamento.Descripcion,
                Activo         = departamento.Activo
            };
        }
    }
}
