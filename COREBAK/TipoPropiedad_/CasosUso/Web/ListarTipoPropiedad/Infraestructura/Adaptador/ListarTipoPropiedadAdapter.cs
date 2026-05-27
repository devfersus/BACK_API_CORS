using COREBAK.TipoPropiedad_.CasosUso.Web.ListarTipoPropiedad.Dominio.Interface;
using COREBAK.TipoPropiedad_.Entidad.Base;
using COREBAK.TipoPropiedad_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.ListarTipoPropiedad.Infraestructura.Adaptador
{
    public class ListarTipoPropiedadAdapter : IListarTipoPropiedad
    {
        public readonly TipoPropiedadDataBaseContext _context;

        public ListarTipoPropiedadAdapter(TipoPropiedadDataBaseContext context)
        {
            _context = context;
        }

        public async Task<List<TipoPropiedad>> ListarTipoPropiedad()
        {
            return await _context.TipoPropiedadDBContext.ToListAsync();
        }
    }
}