using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Dominio.Interface;

namespace COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Aplicacion
{
    public class SAValidarRegistroRelacionadoPropiedadDetalle
    {
        private readonly IValidarRegistroRelacionadoPropiedadDetalle _repository;

        public SAValidarRegistroRelacionadoPropiedadDetalle(IValidarRegistroRelacionadoPropiedadDetalle repository)
        {
            _repository = repository;
        }

        public async Task EjecutarAsync(Guid tipoPropiedadId)
        {
            bool existeActivo = await _repository.ExisteActivoPorTipoPropiedadAsync(tipoPropiedadId);

            if (existeActivo)
                throw new Exception($"No se puede desactivar el TipoPropiedad con Id {tipoPropiedadId} porque tiene registros activos en PropiedadDetalle.");
        }
    }
}
