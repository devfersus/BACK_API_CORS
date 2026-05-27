using COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Aplicacion;
using COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Dominio.Interface;
using COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Infraestructura.Adaptador;
using COREBAK.TipoListado_.CasosUso.Web.ListarTipoListado.Aplicacion;
using COREBAK.TipoListado_.CasosUso.Web.ListarTipoListado.Dominio.Interface;
using COREBAK.TipoListado_.CasosUso.Web.ListarTipoListado.Infraestructura.Adaptador;
using COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Aplicacion;
using COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Dominio.Interface;
using COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Infraestructura.Adaptador;
using COREBAK.TipoListado_.Entidad.DataBaseContext;
using COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Aplicacion;
using COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Dominio.Interface;
using COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Infraestructura.Adapter;
using COREBAK.TipoListado_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Aplicacion;
using COREBAK.TipoListado_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Dominio.Interface;
using COREBAK.TipoListado_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Infraestructura.Adaptador;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Aplicacion;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoListado.Scoped
{
    public static class TipoListadoScoped
    {
        public static void AddTipoListadoScoped(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<TipoListadoDataBaseContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IActualizarTipoListado, ActualizarTipoListadoAdapter>();
            services.AddScoped<IListarTipoListado, ListarTipoListadoAdapter>();
            services.AddScoped<IRegistrarTipoListado, RegistrarTipoListadoAdapter>();
            services.AddScoped<IObtenerTipoListadoPorIdRepository, ObtenerTipoListadoPorIdAdapter>();
            services.AddScoped<IValidarRegistroRelacionadoPropiedadDetalle, ValidarRegistroRelacionadoPropiedadDetalleAdapter>();

            services.AddScoped<SDTipoListadoRegistrar>();
            services.AddScoped<SDTipoListadoListar>();
            services.AddScoped<SAValidarRegistroRelacionadoPropiedadDetalle>();
            services.AddScoped<SDTipoListadoActualizar>();
            services.AddScoped<SDObtenerTipoListadoPorId>();
        }
    }
}
