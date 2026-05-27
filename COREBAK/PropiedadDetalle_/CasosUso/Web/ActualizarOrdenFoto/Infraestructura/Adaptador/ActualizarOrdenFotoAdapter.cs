using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Dominio.Interface;
using COREBAK.PropiedadDetalle_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Infraestructura.Adaptador
{
    public class ActualizarOrdenFotoAdapter : IActualizarOrdenFoto
    {
        private readonly PropiedadDetalleDataBaseContext _context;

        public ActualizarOrdenFotoAdapter(PropiedadDetalleDataBaseContext context)
        {
            _context = context;
        }

        public async Task ActualizarOrdenFoto(Guid propiedadDetalleFotosId, int orden)
        {
            var foto = await _context.PropiedadDetalleFotoDBContext
                .FirstOrDefaultAsync(f => f.PropiedadDetalleFotos == propiedadDetalleFotosId);

            if (foto == null)
                throw new Exception($"Foto con Id {propiedadDetalleFotosId} no encontrada.");

            foto.Orden = orden;
            await _context.SaveChangesAsync();
        }
    }
}
