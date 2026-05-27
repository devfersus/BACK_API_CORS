using COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Aplicacion.Dto;
using COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Aplicacion.Repository;
using COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Dominio.Interface;
using COREBAK.CodigoPromocion_.Entidad.Base;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Aplicacion
{
    public class SDActualizarCodigoPromocion
        (IActualizarCodigoPromocion actualizarCodigoPromocion)
        : ActualizarCodigoPromocionRepository
    {
        private readonly IActualizarCodigoPromocion _actualizarCodigoPromocion = actualizarCodigoPromocion;

        public async Task ActualizarCodigoPromocion(ActualizarCodigoPromocionDTO dto)
        {
            var codigoPromocion = new CodigoPromocion(
                codigoPromocionId: dto.CodigoPromocionId,
                descripcion:       dto.Descripcion,
                activo:            dto.Activo,
                fechaRegistro:     DateTime.Now,
                usuarioRegistro:   string.Empty
            );

            await _actualizarCodigoPromocion.ActualizarCodigoPromocion(codigoPromocion);
        }
    }
}
