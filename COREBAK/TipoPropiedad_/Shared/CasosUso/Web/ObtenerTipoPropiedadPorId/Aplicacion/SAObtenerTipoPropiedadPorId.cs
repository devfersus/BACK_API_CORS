using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Aplicacion.Dto;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Dominio.Interface;

namespace COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Aplicacion
{
    public class SAObtenerTipoPropiedadPorId
    {
        public readonly IObtenerTipoPropiedadPorId _repository;

        public SAObtenerTipoPropiedadPorId(IObtenerTipoPropiedadPorId repository)
        {
            _repository = repository;
        }

        public async Task<ObtenerTipoPropiedadPorIdDto> EjecutarAsync(Guid tipoPropiedadId)
        {
            var tipoPropiedad = await _repository.ObtenerPorIdAsync(tipoPropiedadId);

            if (tipoPropiedad == null)
                throw new Exception($"TipoPropiedad con Id {tipoPropiedadId} no encontrado.");

            return new ObtenerTipoPropiedadPorIdDto
            {
                TipoPropiedadId = tipoPropiedad.TipoPropiedadId,
                Descripcion = tipoPropiedad.Descripcion,
                Activo = tipoPropiedad.Activo,
                FechaRegistro = tipoPropiedad.FechaRegistro,
                UsuarioRegistro = tipoPropiedad.UsuarioRegistro
            };
        }
    }
}