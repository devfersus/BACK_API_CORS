using COREBAK.TipoPropiedad_.CasosUso.Web.EliminarTipoPropiedad.Dominio.Interface;
using COREBAK.TipoPropiedad_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.EliminarTipoPropiedad.Infraestructura.Adaptador
{
    public class EliminarTipoPropiedadAdapter : IEliminarTipoPropiedad
    {
        public readonly TipoPropiedadDataBaseContext _context;

        public EliminarTipoPropiedadAdapter(TipoPropiedadDataBaseContext context)
        {
            _context = context;
        }

        public async Task EliminarTipoPropiedad(Guid id)
        {
            // Busca el registro
            var tipoPropiedad = await _context.TipoPropiedadDBContext
                .FirstOrDefaultAsync(tipoPropiedad=> tipoPropiedad.TipoPropiedadId == id
                                        && tipoPropiedad.Activo);

            if (tipoPropiedad == null)
                throw new Exception("Tipo de propiedad no encontrado o ya fue eliminado.");

            tipoPropiedad.Activo = false;

            await _context.SaveChangesAsync();
        }
    }
}
