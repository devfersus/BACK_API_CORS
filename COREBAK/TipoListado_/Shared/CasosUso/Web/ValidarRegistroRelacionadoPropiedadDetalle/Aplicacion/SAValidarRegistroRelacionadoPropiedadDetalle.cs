using COREBAK.TipoListado_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Dominio.Interface;

namespace COREBAK.TipoListado_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Aplicacion
{
    public class SAValidarRegistroRelacionadoPropiedadDetalle
    {
        private readonly IValidarRegistroRelacionadoPropiedadDetalle _repository;

        public SAValidarRegistroRelacionadoPropiedadDetalle(IValidarRegistroRelacionadoPropiedadDetalle repository)
        {
            _repository = repository;
        }

        public async Task EjecutarAsync(Guid tipoListadoId)
        {
            bool existeActivo = await _repository.ExisteActivoPorTipoListadoAsync(tipoListadoId);

            if (existeActivo)
                throw new Exception($"No se puede desactivar el TipoListado con Id {tipoListadoId} porque tiene registros activos en PropiedadDetalle.");
        }
    }
}
