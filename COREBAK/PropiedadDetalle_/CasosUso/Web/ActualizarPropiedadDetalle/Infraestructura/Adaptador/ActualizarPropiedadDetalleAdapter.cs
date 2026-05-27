using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Dominio.Interface;
using COREBAK.PropiedadDetalle_.Entidad.Base;
using COREBAK.PropiedadDetalle_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Infraestructura.Adaptador
{
    public class ActualizarPropiedadDetalleAdapter : IActualizarPropiedadDetalle
    {
        public readonly PropiedadDetalleDataBaseContext _context;

        public ActualizarPropiedadDetalleAdapter(PropiedadDetalleDataBaseContext context)
        {
            _context = context;
        }

        public async Task actualizarPropiedadDetalle(PropiedadDetalle propiedadDetalle)
        {
            var registro = await _context.PropiedadDetalleDBContext
                .FirstOrDefaultAsync(propiedadDetalleFilter =>
                propiedadDetalleFilter.PropiedadListadoId == propiedadDetalle.PropiedadListadoId);

            if (registro == null)
                throw new Exception("Propiedad detalle no encontrada.");

            bool quedaActivaConPromocion = propiedadDetalle.Activo && propiedadDetalle.CodigoPromocionId.HasValue;
            bool yaEraActivaConMismaPromocion = registro.Activo && registro.CodigoPromocionId == propiedadDetalle.CodigoPromocionId;

            if (quedaActivaConPromocion && !yaEraActivaConMismaPromocion)
            {
                var totalConPromocion = await _context.PropiedadDetalleDBContext
                    .CountAsync(p => p.CodigoPromocionId != null
                              && p.Activo
                              && p.PropiedadListadoId != propiedadDetalle.PropiedadListadoId);

                if (totalConPromocion >= 3)
                    throw new Exception("No se pueden tener más de 3 propiedades con código de promoción.");
            }

            registro.actualizarPropiedadDetalle(
                propiedadDetalle.TipoPropiedadId,
                propiedadDetalle.TipoListadoId,
                propiedadDetalle.Titulo,
                propiedadDetalle.Descripcion,
                propiedadDetalle.Precio,
                propiedadDetalle.CodigoPromocionId,
                propiedadDetalle.Activo,
                propiedadDetalle.DepartamentoId,
                propiedadDetalle.DescripcionFinal,
                propiedadDetalle.Orden,
                propiedadDetalle.Ubicacion,
                propiedadDetalle.AreaTerreno,
                propiedadDetalle.TipoMoneda
            );

            await _context.SaveChangesAsync();
        }
    }
}