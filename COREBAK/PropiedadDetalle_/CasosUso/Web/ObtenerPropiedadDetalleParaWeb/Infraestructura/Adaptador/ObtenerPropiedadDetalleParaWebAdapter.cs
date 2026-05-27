using COREBAK.CodigoPromocion_.Entidad.DataBaseContext;
using COREBAK.Departamento_.Entidad.DataBaseContext;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Aplicacion.Dto;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Dominio.Interface;
using COREBAK.PropiedadDetalle_.Entidad.DataBaseContext;
using COREBAK.TipoListado_.Entidad.DataBaseContext;
using COREBAK.TipoPropiedad_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Infraestructura.Adaptador
{
    public class ObtenerPropiedadDetalleParaWebAdapter : IObtenerPropiedadDetalleParaWeb
    {
        private readonly PropiedadDetalleDataBaseContext _propiedadContext;
        private readonly CodigoPromocionDataBaseContext  _promoContext;
        private readonly TipoListadoDataBaseContext      _tipoListadoContext;
        private readonly TipoPropiedadDataBaseContext    _tipoPropiedadContext;
        private readonly DepartamentoDataBaseContext     _departamentoContext;

        public ObtenerPropiedadDetalleParaWebAdapter(
            PropiedadDetalleDataBaseContext propiedadContext,
            CodigoPromocionDataBaseContext  promoContext,
            TipoListadoDataBaseContext      tipoListadoContext,
            TipoPropiedadDataBaseContext    tipoPropiedadContext,
            DepartamentoDataBaseContext     departamentoContext)
        {
            _propiedadContext    = propiedadContext;
            _promoContext        = promoContext;
            _tipoListadoContext  = tipoListadoContext;
            _tipoPropiedadContext = tipoPropiedadContext;
            _departamentoContext  = departamentoContext;
        }

        public async Task<ListarPropiedadDetalleParaWebPaginadoDTO> ListarAsync(int numeroPagina, int tamanioPagina)
        {
            var totalRegistros = await _propiedadContext.PropiedadDetalleDBContext.CountAsync();

            var propiedades = await _propiedadContext.PropiedadDetalleDBContext
                .Include(p => p.Fotos)
                .Skip((numeroPagina - 1) * tamanioPagina)
                .Take(tamanioPagina)
                .ToListAsync();

            // Cargar descripciones de CodigoPromocion
            var promoIds = propiedades
                .Where(p => p.CodigoPromocionId.HasValue && p.CodigoPromocionId > 0)
                .Select(p => p.CodigoPromocionId!.Value)
                .Distinct().ToList();

            var promos = await _promoContext.CodigoPromocionDBContext
                .Where(p => promoIds.Contains(p.CodigoPromocionId))
                .ToDictionaryAsync(p => p.CodigoPromocionId, p => p.Descripcion);

            // Cargar descripciones de TipoListado
            var tipoListadoIds = propiedades.Select(p => p.TipoListadoId).Distinct().ToList();
            var tiposListado = await _tipoListadoContext.TipoListadoDBContext
                .Where(t => tipoListadoIds.Contains(t.TipoListadoId))
                .ToDictionaryAsync(t => t.TipoListadoId, t => t.Descripcion);

            // Cargar descripciones de TipoPropiedad
            var tipoPropiedadIds = propiedades.Select(p => p.TipoPropiedadId).Distinct().ToList();
            var tiposPropiedad = await _tipoPropiedadContext.TipoPropiedadDBContext
                .Where(t => tipoPropiedadIds.Contains(t.TipoPropiedadId))
                .ToDictionaryAsync(t => t.TipoPropiedadId, t => t.Descripcion);

            // Cargar descripciones de Departamento
            var departamentoIds = propiedades
                .Where(p => p.DepartamentoId.HasValue)
                .Select(p => p.DepartamentoId!.Value)
                .Distinct().ToList();
            var departamentos = await _departamentoContext.DepartamentoDBContext
                .Where(d => departamentoIds.Contains(d.DepartamentoId))
                .ToDictionaryAsync(d => d.DepartamentoId, d => d.Descripcion);

            var items = propiedades.Select(p => new ObtenerPropiedadDetalleParaWebDTO
            {
                PropiedadListadoId      = p.PropiedadListadoId,
                TipoPropiedadId         = p.TipoPropiedadId,
                DescripcionTipoPropiedad = tiposPropiedad.TryGetValue(p.TipoPropiedadId, out string? dtp) ? dtp : null,
                TipoListadoId           = p.TipoListadoId,
                DescripcionTipoListado  = tiposListado.TryGetValue(p.TipoListadoId, out string? dtl) ? dtl : null,
                Titulo                  = p.Titulo,
                Descripcion             = p.Descripcion,
                Precio                  = p.Precio,
                ContadorClicks          = p.ContadorClicks,
                CodigoPromocionId       = p.CodigoPromocionId,
                DescripcionPromocion    = p.CodigoPromocionId.HasValue && promos.TryGetValue(p.CodigoPromocionId.Value, out string? dp)
                                            ? dp : null,
                Activo                  = p.Activo,
                DepartamentoId          = p.DepartamentoId,
                DescripcionDepartamento = p.DepartamentoId.HasValue && departamentos.TryGetValue(p.DepartamentoId.Value, out string? dd)
                                            ? dd : null,
                DescripcionFinal        = p.DescripcionFinal,
                Orden                   = p.Orden,
                Ubicacion               = p.Ubicacion,
                AreaTerreno             = p.AreaTerreno,
                TipoMoneda              = p.TipoMoneda,
                Fotos                   = p.Fotos.OrderBy(f => f.Orden).Select(f => new ObtenerPropiedadDetalleParaWebFotoDTO
                {
                    PropiedadDetalleFotosId = f.PropiedadDetalleFotos,
                    Foto                    = f.Foto,
                    Activo                  = f.Activo,
                    Orden                   = f.Orden
                }).ToList()
            }).ToList();

            return new ListarPropiedadDetalleParaWebPaginadoDTO
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
