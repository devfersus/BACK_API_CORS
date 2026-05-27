using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Aplicacion.Dto;
using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Dominio.Interface;
using COREBAK.CodigoPromocion_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Infraestructura.Adaptador
{
    public class ListarCodigoPromocionAdapter : IListarCodigoPromocion
    {
        private readonly CodigoPromocionDataBaseContext _context;

        public ListarCodigoPromocionAdapter(CodigoPromocionDataBaseContext context)
        {
            _context = context;
        }

        public async Task<ListarCodigoPromocionPaginadoDTO> ListarCodigoPromocion(int numeroPagina, int tamanioPagina)
        {
            var totalRegistros = await _context.CodigoPromocionDBContext.CountAsync();

            var items = await _context.CodigoPromocionDBContext
                .Skip((numeroPagina - 1) * tamanioPagina)
                .Take(tamanioPagina)
                .ToListAsync();

            return new ListarCodigoPromocionPaginadoDTO
            {
                Items         = items,
                TotalRegistros = totalRegistros,
                TotalPaginas  = (int)Math.Ceiling((double)totalRegistros / tamanioPagina),
                NumeroPagina  = numeroPagina,
                TamanioPagina = tamanioPagina
            };
        }
    }
}
