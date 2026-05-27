using COREBAK.PropiedadDetalle_.Entidad.DataBaseContext;
using COREBAK.TipoListado_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Dominio.Interface;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.TipoListado_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Infraestructura.Adaptador
{
    public class ValidarRegistroRelacionadoPropiedadDetalleAdapter : IValidarRegistroRelacionadoPropiedadDetalle
    {
        private readonly PropiedadDetalleDataBaseContext _context;

        public ValidarRegistroRelacionadoPropiedadDetalleAdapter(PropiedadDetalleDataBaseContext context)
        {
            _context = context;
        }

        public async Task<bool> ExisteActivoPorTipoListadoAsync(Guid tipoListadoId)
        {
            return await _context.PropiedadDetalleDBContext
                .AnyAsync(p => p.TipoListadoId == tipoListadoId && p.Activo);
        }
    }
}
