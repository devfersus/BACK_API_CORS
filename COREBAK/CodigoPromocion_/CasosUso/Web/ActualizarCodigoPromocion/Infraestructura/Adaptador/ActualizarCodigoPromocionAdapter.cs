using COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Dominio.Interface;
using COREBAK.CodigoPromocion_.Entidad.Base;
using COREBAK.CodigoPromocion_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Infraestructura.Adaptador
{
    public class ActualizarCodigoPromocionAdapter : IActualizarCodigoPromocion
    {
        private readonly CodigoPromocionDataBaseContext _context;

        public ActualizarCodigoPromocionAdapter(CodigoPromocionDataBaseContext context)
        {
            _context = context;
        }

        public async Task ActualizarCodigoPromocion(CodigoPromocion codigoPromocion)
        {
            var registro = await _context.CodigoPromocionDBContext
                .FirstOrDefaultAsync(x => x.CodigoPromocionId == codigoPromocion.CodigoPromocionId);

            if (registro == null)
                throw new Exception($"CodigoPromocion con Id {codigoPromocion.CodigoPromocionId} no encontrado.");

            registro.Actualizar(codigoPromocion.Descripcion, codigoPromocion.Activo);

            await _context.SaveChangesAsync();
        }
    }
}
