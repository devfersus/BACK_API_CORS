using COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Aplicacion;
using COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Dominio.Interface;
using COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Infraestructura.Adaptador;
using COREBAK.TipoPropiedad_.CasosUso.Web.ListarTipoPropiedad.Aplicacion;
using COREBAK.TipoPropiedad_.CasosUso.Web.ListarTipoPropiedad.Dominio.Interface;
using COREBAK.TipoPropiedad_.CasosUso.Web.ListarTipoPropiedad.Infraestructura.Adaptador;
using COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Aplicacion;
using COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Dominio.Interface;
using COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Infraestructura.Adaptador;
using COREBAK.TipoPropiedad_.Entidad.DataBaseContext;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Aplicacion;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Dominio.Interface;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Infraestructura.Adapter;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Aplicacion;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Dominio.Interface;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Infraestructura.Adaptador;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoPropiedad.Scoped
{
    public static class TipoPropiedadScoped
    {
        public static void AddTipoPropiedadScoped(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<TipoPropiedadDataBaseContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRegistrarTipoPropiedad, RegistrarTipoPropiedadAdapter>();
            //services.AddScoped<IEliminarTipoPropiedad, EliminarTipoPropiedadAdapter>();
            services.AddScoped<IActualizarTipoPropiedad, ActualizarTipoPropiedadAdapter>();
            services.AddScoped<IListarTipoPropiedad, ListarTipoPropiedadAdapter>();
            services.AddScoped<IObtenerTipoPropiedadPorId, ObtenerTipoPropiedadPorIdAdapter>();
            services.AddScoped<IValidarRegistroRelacionadoPropiedadDetalle, ValidarRegistroRelacionadoPropiedadDetalleAdapter>();

            services.AddScoped<SDListarTipoPropiedad>();
            services.AddScoped<SAObtenerTipoPropiedadPorId>();
            services.AddScoped<SAValidarRegistroRelacionadoPropiedadDetalle>();
            services.AddScoped<ServicioAplicacion>();
            services.AddScoped<SDRegistaraTipoPropiedad>();


        }
    }
}
