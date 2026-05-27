using COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Aplicacion.Dto;
using COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Dominio.Interface;

namespace COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Aplicacion
{
    public class SAObtenerCodigoPromocionPorId
    {
        private readonly IObtenerCodigoPromocionPorId _repository;

        public SAObtenerCodigoPromocionPorId(IObtenerCodigoPromocionPorId repository)
        {
            _repository = repository;
        }

        public async Task<ObtenerCodigoPromocionPorIdDto> EjecutarAsync(int codigoPromocionId)
        {
            var codigoPromocion = await _repository.ObtenerPorIdAsync(codigoPromocionId);

            if (codigoPromocion == null)
                throw new Exception($"CodigoPromocion con Id {codigoPromocionId} no encontrado.");

            return new ObtenerCodigoPromocionPorIdDto
            {
                CodigoPromocionId = codigoPromocion.CodigoPromocionId,
                Descripcion       = codigoPromocion.Descripcion,
                Activo            = codigoPromocion.Activo,
                FechaRegistro     = codigoPromocion.FechaRegistro,
                UsuarioRegistro   = codigoPromocion.UsuarioRegistro
            };
        }
    }
}
