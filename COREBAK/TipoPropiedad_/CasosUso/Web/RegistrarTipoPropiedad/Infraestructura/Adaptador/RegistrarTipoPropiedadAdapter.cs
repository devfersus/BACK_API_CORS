using COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Dominio.Interface;
using COREBAK.TipoPropiedad_.Entidad.Base;
using COREBAK.TipoPropiedad_.Entidad.DataBaseContext;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Infraestructura.Adaptador
{
    public class RegistrarTipoPropiedadAdapter
        : IRegistrarTipoPropiedad
    {
        public readonly TipoPropiedadDataBaseContext _context;


        public RegistrarTipoPropiedadAdapter(TipoPropiedadDataBaseContext context)
        {
            _context = context;
        }
        public async Task RegistrarTipoPropiedad(TipoPropiedad tipoPropiedad)
        {
            _context.TipoPropiedadDBContext.Add(tipoPropiedad);
            await _context.SaveChangesAsync();
        }
    }
}