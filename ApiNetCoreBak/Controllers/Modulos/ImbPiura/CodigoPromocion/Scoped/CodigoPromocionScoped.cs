using COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Aplicacion;
using COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Dominio.Interface;
using COREBAK.CodigoPromocion_.CasosUso.Web.ActualizarCodigoPromocion.Infraestructura.Adaptador;
using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Aplicacion;
using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Dominio.Interface;
using COREBAK.CodigoPromocion_.CasosUso.Web.ListarCodigoPromocion.Infraestructura.Adaptador;
using COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Aplicacion;
using COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Dominio.Interface;
using COREBAK.CodigoPromocion_.CasosUso.Web.RegistrarCodigoPromocion.Infraestructura.Adaptador;
using COREBAK.CodigoPromocion_.Entidad.DataBaseContext;
using COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Aplicacion;
using COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Dominio.Interface;
using COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Infraestructura.Adaptador;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.CodigoPromocion.Scoped
{
    public static class CodigoPromocionScoped
    {
        public static void AddCodigoPromocionScoped(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CodigoPromocionDataBaseContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IListarCodigoPromocion, ListarCodigoPromocionAdapter>();
            services.AddScoped<IRegistrarCodigoPromocion, RegistrarCodigoPromocionAdapter>();
            services.AddScoped<IActualizarCodigoPromocion, ActualizarCodigoPromocionAdapter>();
            services.AddScoped<IObtenerCodigoPromocionPorId, ObtenerCodigoPromocionPorIdAdapter>();

            services.AddScoped<SDListarCodigoPromocion>();
            services.AddScoped<SDRegistrarCodigoPromocion>();
            services.AddScoped<SDActualizarCodigoPromocion>();
            services.AddScoped<SAObtenerCodigoPromocionPorId>();
        }
    }
}
