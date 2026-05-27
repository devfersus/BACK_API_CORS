using COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Dominio.Interface;
using COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ObtenerPropiedadDetalleId.Aplicacion.Dto;
using COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ObtenerPropiedadDetalleId.Dominio.Interface;

namespace COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ObtenerPropiedadDetalleId.Aplicacion
{
    public class SAObtenerPropiedadDetallePorId
    {
        private readonly IObtenerPropiedadDetallePorId _repository;
        private readonly IObtenerCodigoPromocionPorId _obtenerPromocion;

        public SAObtenerPropiedadDetallePorId(
            IObtenerPropiedadDetallePorId repository,
            IObtenerCodigoPromocionPorId obtenerPromocion)
        {
            _repository       = repository;
            _obtenerPromocion = obtenerPromocion;
        }

        public async Task<ObtenerPropiedadDetallePorIdDto> EjecutarAsync(Guid propiedadListadoId)
        {
            var propiedadDetalle = await _repository.ObtenerPorIdAsync(propiedadListadoId);

            if (propiedadDetalle == null)
                throw new Exception($"PropiedadDetalle con Id {propiedadListadoId} no encontrado.");

            var descripcionPromocion = propiedadDetalle.CodigoPromocionId.HasValue
                ? (await _obtenerPromocion.ObtenerPorIdAsync(propiedadDetalle.CodigoPromocionId.Value))?.Descripcion
                : null;

            return new ObtenerPropiedadDetallePorIdDto
            {
                PropiedadListadoId   = propiedadDetalle.PropiedadListadoId,
                TipoPropiedadId      = propiedadDetalle.TipoPropiedadId,
                TipoListadoId        = propiedadDetalle.TipoListadoId,
                Titulo               = propiedadDetalle.Titulo,
                Descripcion          = propiedadDetalle.Descripcion,
                Precio               = propiedadDetalle.Precio,
                ContadorClicks       = propiedadDetalle.ContadorClicks,
                CodigoPromocionId    = propiedadDetalle.CodigoPromocionId,
                DescripcionPromocion = descripcionPromocion,
                Activo               = propiedadDetalle.Activo,
                DepartamentoId       = propiedadDetalle.DepartamentoId,
                DescripcionFinal     = propiedadDetalle.DescripcionFinal,
                Orden                = propiedadDetalle.Orden,
                Ubicacion            = propiedadDetalle.Ubicacion,
                AreaTerreno          = propiedadDetalle.AreaTerreno,
                TipoMoneda           = propiedadDetalle.TipoMoneda,
                Fotos                = propiedadDetalle.Fotos.OrderBy(f => f.Orden).Select(f => new ObtenerPropiedadDetalleFotoDto
                {
                    PropiedadDetalleFotosId = f.PropiedadDetalleFotos,
                    Foto                    = f.Foto,
                    Activo                  = f.Activo,
                    Orden                   = f.Orden
                }).ToList()
            };
        }
    }
}
