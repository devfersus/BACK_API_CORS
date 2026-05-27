using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion.Dto;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Dominio.Interface;
using COREBAK.PropiedadDetalle_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Infraestructura.Adaptador
{
    public class ListarPropiedadDetalleAdapter : IListarPropiedadDetalle
    {
        public readonly PropiedadDetalleDataBaseContext _context;

        public ListarPropiedadDetalleAdapter(PropiedadDetalleDataBaseContext context)
        {
            _context = context;
        }

        public async Task<ListarPropiedadDetallePaginadoDTO> ListarPropiedadDetalle(int numeroPagina, int tamanioPagina)
        {
            var totalRegistros = await _context.PropiedadDetalleDBContext.CountAsync();

            var items = await _context.PropiedadDetalleDBContext
                .Include(p => p.Fotos)
                .Skip((numeroPagina - 1) * tamanioPagina)
                .Take(tamanioPagina)
                .Select(p => new ListarPropiedadDetalleItemDTO
                {
                    PropiedadListadoId = p.PropiedadListadoId,
                    TipoPropiedadId = p.TipoPropiedadId,
                    TipoListadoId = p.TipoListadoId,
                    Titulo = p.Titulo,
                    Descripcion = p.Descripcion,
                    Precio = p.Precio,
                    ContadorClicks = p.ContadorClicks,
                    CodigoPromocionId = p.CodigoPromocionId,
                    Activo = p.Activo,
                    DepartamentoId = p.DepartamentoId,
                    DescripcionFinal = p.DescripcionFinal,
                    Orden = p.Orden,
                    Ubicacion = p.Ubicacion,
                    AreaTerreno = p.AreaTerreno,
                    TipoMoneda = p.TipoMoneda,
                    Fotos = p.Fotos.OrderBy(f => f.Orden).Select(f => new PropiedadDetalleFotoDTO
                    {
                        PropiedadDetalleFotosId = f.PropiedadDetalleFotos,
                        Foto   = f.Foto,
                        Activo = f.Activo,
                        Orden  = f.Orden
                    }).ToList()
                })
                .ToListAsync();

            return new ListarPropiedadDetallePaginadoDTO
            {
                Items = items,
                TotalRegistros = totalRegistros,
                TotalPaginas = (int)Math.Ceiling((double)totalRegistros / tamanioPagina),
                NumeroPagina = numeroPagina,
                TamanioPagina = tamanioPagina
            };
        }
    }
}