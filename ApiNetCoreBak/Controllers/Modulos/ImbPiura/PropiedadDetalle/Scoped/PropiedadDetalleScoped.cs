using COREBAK.CodigoPromocion_.Entidad.DataBaseContext;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Dominio.Interface;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Infraestructura.Adaptador;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Dominio.Interface;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Infraestructura.Adaptador;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Dominio.Interface;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Infraestructura.Adaptador;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Dominio.Interface;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Infraestructura.Adaptador;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Dominio.Interface;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ObtenerPropiedadDetalleParaWeb.Infraestructura.Adaptador;
using COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Dominio.Interface;
using COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Infraestructura.Adaptador;
using COREBAK.PropiedadDetalle_.Entidad.DataBaseContext;
using COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ObtenerPropiedadDetalleId.Aplicacion;
using COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ObtenerPropiedadDetalleId.Dominio.Interface;
using COREBAK.PropiedadDetalle_.Shared.CasosUso.Web.ObtenerPropiedadDetalleId.Infraestructura.Adaptador;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Dominio.Interface;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Infraestructura.Adapter;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.PropiedadDetalle.Scoped
{
    public static class PropiedadDetalleScoped
    {
        public static void AddPropiedadDetalleScoped(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<PropiedadDetalleDataBaseContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IActivarDesactivarFoto, ActivarDesactivarFotoAdapter>();
            services.AddScoped<IActualizarOrdenFoto, ActualizarOrdenFotoAdapter>();
            services.AddScoped<IRegistrarPropiedadDetalle, RegistrarPropiedadDetalleAdapter>();
            services.AddScoped<IActualizarPropiedadDetalle, ActualizarPropiedadDetalleAdapter>();
            services.AddScoped<IListarPropiedadDetalle, ListarPropiedadDetalleAdapter>();
            services.AddScoped<IObtenerPropiedadDetallePorId, ObtenerPropiedadDetallePorIdAdapter>();
            services.AddScoped<IObtenerPropiedadDetalleParaWeb, ObtenerPropiedadDetalleParaWebAdapter>();

            services.AddScoped<SDActivarDesactivarFoto>();
            services.AddScoped<SDActualizarOrdenFoto>();
            services.AddScoped<SDRegistrarPropiedadDetalle>();
            services.AddScoped<SDActualizarPropiedadDetalle>();
            services.AddScoped<SDListarPropiedadDetalle>();
            services.AddScoped<SAObtenerPropiedadDetallePorId>();
            services.AddScoped<SDObtenerPropiedadDetalleParaWeb>();
        }
    }
}
