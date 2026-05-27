using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Aplicacion.Dto;
using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Dominio.Interface;
using COREBAK.Departamento_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Infraestructura.Adaptador
{
    public class ListarDepartamentoAdapter : IListarDepartamento
    {
        public readonly DepartamentoDataBaseContext _context;

        public ListarDepartamentoAdapter(DepartamentoDataBaseContext context)
        {
            _context = context;
        }

        public async Task<ListarDepartamentoPaginadoDTO> ListarDepartamento(int numeroPagina, int tamanioPagina)
        {
            var totalRegistros = await _context.DepartamentoDBContext.CountAsync();

            var items = await _context.DepartamentoDBContext
                .Skip((numeroPagina - 1) * tamanioPagina)
                .Take(tamanioPagina)
                .ToListAsync();

            return new ListarDepartamentoPaginadoDTO
            {
                Items          = items,
                TotalRegistros = totalRegistros,
                TotalPaginas   = (int)Math.Ceiling((double)totalRegistros / tamanioPagina),
                NumeroPagina   = numeroPagina,
                TamanioPagina  = tamanioPagina
            };
        }
    }
}
