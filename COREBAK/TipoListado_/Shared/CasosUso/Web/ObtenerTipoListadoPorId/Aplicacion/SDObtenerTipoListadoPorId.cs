using COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Aplicacion.Dto;
using COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Dominio.Interface;

namespace COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Aplicacion
{
    public class SDObtenerTipoListadoPorId 
    {
        private readonly IObtenerTipoListadoPorIdRepository _repository;

        public SDObtenerTipoListadoPorId(IObtenerTipoListadoPorIdRepository repository)
        {
            _repository = repository;
        }

        public async Task<ObtenerTipoListadoPorIdDto> EjecutarAsync(Guid tipoListadoId)
        {
            var tipoListado = await _repository.ObtenerPorIdAsync(tipoListadoId);

            if (tipoListado == null)
                throw new Exception($"TipoListado con Id {tipoListadoId} no encontrado.");

            return new ObtenerTipoListadoPorIdDto
            {
                TipoListadoId = tipoListado.TipoListadoId,
                Descripcion = tipoListado.Descripcion,
                Activo = tipoListado.Activo,
                FechaRegistro = tipoListado.FechaRegistro,
                UsuarioRegistro = tipoListado.UsuarioRegistro
            };
        }
    }
}