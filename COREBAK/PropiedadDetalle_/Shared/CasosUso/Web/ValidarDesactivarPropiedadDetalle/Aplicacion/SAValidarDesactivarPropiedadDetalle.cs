using COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ValidarDesactivarPropiedadDetalle.Dominio.Interface;

namespace COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ValidarDesactivarPropiedadDetalle.Aplicacion
{
    public class SAValidarDesactivarPropiedadDetalle
    {
        private readonly IValidarDesactivarPropiedadDetalle _repository;

        public SAValidarDesactivarPropiedadDetalle(IValidarDesactivarPropiedadDetalle repository)
        {
            _repository = repository;
        }

        public async Task EjecutarAsync(Guid propiedadListadoId)
        {
            var propiedadDetalle = await _repository.ObtenerPorIdAsync(propiedadListadoId);

            if (propiedadDetalle == null)
                throw new Exception($"PropiedadDetalle con Id {propiedadListadoId} no encontrada.");

            if (propiedadDetalle.Activo)
                throw new Exception($"No se puede desactivar el registro con Id {propiedadListadoId} porque se encuentra activo.");
        }
    }
}
