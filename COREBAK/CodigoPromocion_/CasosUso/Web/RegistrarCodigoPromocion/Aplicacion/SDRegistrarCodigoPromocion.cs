using COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Aplicacion.Dto;
using COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Aplicacion.Repository;
using COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Dominio.Interface;
using COREBAK.CodigoPromocion_.Entidad.Base;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Aplicacion
{
    public class SDRegistrarCodigoPromocion
        (IRegistrarCodigoPromocion registrarCodigoPromocion)
        : RegistrarCodigoPromocionRepository
    {
        private readonly IRegistrarCodigoPromocion _registrarCodigoPromocion = registrarCodigoPromocion;

        public async Task RegistrarCodigoPromocion(RegistrarCodigoPromocionDTO dto)
        {
            var codigoPromocion = new CodigoPromocion(
                codigoPromocionId: dto.CodigoPromocionId,
                descripcion:       dto.Descripcion,
                activo:            true,
                fechaRegistro:     DateTime.Now,
                usuarioRegistro:   dto.UsuarioRegistro
            );

            await _registrarCodigoPromocion.RegistrarCodigoPromocion(codigoPromocion);
        }
    }
}
