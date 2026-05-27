using COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Dominio.Interface;
using COREBAK.PropiedadDetalle_.Entidad.Base;
using COREBAK.PropiedadDetalle_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Infraestructura.Adaptador
{
    public class RegistrarPropiedadDetalleAdapter : IRegistrarPropiedadDetalle
    {
        public readonly PropiedadDetalleDataBaseContext _context;

        public RegistrarPropiedadDetalleAdapter(PropiedadDetalleDataBaseContext context)
        {
            _context = context;
        }

        public async Task registrarPropiedadDetalle(PropiedadDetalle propiedadDetalle, List<string> urlsFotos, List<int>? ordenesFotos)
        {
            if (propiedadDetalle.CodigoPromocionId.HasValue)
            {
                var totalConPromocion = await _context.PropiedadDetalleDBContext
                    .CountAsync(p => p.CodigoPromocionId != null);

                if (totalConPromocion >= 3)
                    throw new Exception("No se pueden tener más de 3 propiedades con código de promoción.");
            }

            _context.PropiedadDetalleDBContext.Add(propiedadDetalle);
            await _context.SaveChangesAsync();

            for (int i = 0; i < urlsFotos.Count; i++)
            {
                _context.PropiedadDetalleFotoDBContext.Add(new PropiedadDetalleFoto
                {
                    PropiedadDetalleFotos = Guid.NewGuid(),
                    PropiedadListadoId    = propiedadDetalle.PropiedadListadoId,
                    Foto                  = urlsFotos[i],
                    Activo                = true,
                    Orden                 = (ordenesFotos != null && i < ordenesFotos.Count) ? ordenesFotos[i] : i + 1
                });
            }

            if (urlsFotos.Count > 0)
                await _context.SaveChangesAsync();
        }
    }
}