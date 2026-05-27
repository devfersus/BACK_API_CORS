using COREBAK.TipoPropiedad_.Entidad.Base;
using COREBAK.TipoPropiedad_.Entidad.DataBaseContext;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Dominio.Interface;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Infraestructura.Adapter
{
    public class ObtenerTipoPropiedadPorIdAdapter : IObtenerTipoPropiedadPorId
    {
        private readonly TipoPropiedadDataBaseContext _context;

        public ObtenerTipoPropiedadPorIdAdapter(TipoPropiedadDataBaseContext context)
        {
            _context = context;
        }

        public async Task<TipoPropiedad> ObtenerPorIdAsync(Guid tipoPropiedadId)
        {
            return await _context.TipoPropiedadDBContext
                .FirstOrDefaultAsync(t => t.TipoPropiedadId == tipoPropiedadId);
        }
    }
}