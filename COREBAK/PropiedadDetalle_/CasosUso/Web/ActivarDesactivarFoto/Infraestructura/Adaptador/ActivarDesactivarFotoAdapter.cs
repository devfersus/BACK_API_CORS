using COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Dominio.Interface;
using COREBAK.PropiedadDetalle_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Infraestructura.Adaptador
{
    public class ActivarDesactivarFotoAdapter : IActivarDesactivarFoto
    {
        private readonly PropiedadDetalleDataBaseContext _context;

        public ActivarDesactivarFotoAdapter(PropiedadDetalleDataBaseContext context)
        {
            _context = context;
        }

        public async Task ActivarDesactivarFoto(Guid propiedadDetalleFotosId, bool activo)
        {
            var foto = await _context.PropiedadDetalleFotoDBContext
                .FirstOrDefaultAsync(f => f.PropiedadDetalleFotos == propiedadDetalleFotosId);

            if (foto == null)
                throw new Exception($"Foto con Id {propiedadDetalleFotosId} no encontrada.");

            foto.Activo = activo;
            await _context.SaveChangesAsync();
        }
    }
}
