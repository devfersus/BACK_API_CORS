using COREBAK.PropiedadDetalle_.Entidad.DataBaseContext;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Dominio.Interface;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Infraestructura.Adaptador
{
    public class ValidarRegistroRelacionadoPropiedadDetalleAdapter : IValidarRegistroRelacionadoPropiedadDetalle
    {
        private readonly PropiedadDetalleDataBaseContext _context;

        public ValidarRegistroRelacionadoPropiedadDetalleAdapter(PropiedadDetalleDataBaseContext context)
        {
            _context = context;
        }

        public async Task<bool> ExisteActivoPorTipoPropiedadAsync(Guid tipoPropiedadId)
        {
            return await _context.PropiedadDetalleDBContext
                .AnyAsync(p => p.TipoPropiedadId == tipoPropiedadId && p.Activo);
        }
    }
}
