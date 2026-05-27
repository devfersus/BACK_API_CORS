using COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Dominio.Interface;
using COREBAK.TipoPropiedad_.Entidad.Base;
using COREBAK.TipoPropiedad_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Infraestructura.Adaptador
{
    public class ActualizarTipoPropiedadAdapter : IActualizarTipoPropiedad
    {
        public readonly TipoPropiedadDataBaseContext _context;

        public ActualizarTipoPropiedadAdapter(TipoPropiedadDataBaseContext context)
        {
            _context = context;
        }

        public async Task ActualizarTipoPropiedad(TipoPropiedad tipoPropiedad)
        {
            var registro = await _context.TipoPropiedadDBContext
                .FirstOrDefaultAsync(TipoPropiedad => TipoPropiedad.TipoPropiedadId == tipoPropiedad.TipoPropiedadId);

            if (registro == null)
                throw new Exception("Tipo de propiedad no encontrado.");

            registro.ActualizarTipoPropiedad(
                tipoPropiedad.TipoPropiedadId,
                tipoPropiedad.Descripcion,
                tipoPropiedad.Activo
            );

            await _context.SaveChangesAsync();
        }
    }
}