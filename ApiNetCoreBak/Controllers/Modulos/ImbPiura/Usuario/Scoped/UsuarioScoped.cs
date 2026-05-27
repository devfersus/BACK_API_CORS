using ApiNetCoreBak.Controllers.Modulos.JWT.IJwtTokenService_;
using ApiNetCoreBak.Controllers.Modulos.JWT.JwtTokenService_;
using COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Aplicacion;
using COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Dominio.Interface;
using COREBAK.Usuario_.CasosUso.Web.LoginUsuario.Infraestructura.Adaptador;
using COREBAK.Usuario_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.Usuario.Scoped
{
    public static class UsuarioScoped
    {
        public static void AddUsuarioScoped(this IServiceCollection services, string connectionString, IConfiguration configuration)
        {
            services.AddDbContext<UsuarioDataBaseContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<ILoginUsuario, LoginUsuarioAdapter>();
            services.AddScoped<SDLoginUsuario>();

            services.Configure<ApiNetCoreBak.Controllers.Modulos.JWT.JwtSettings>(
                configuration.GetSection("JwtSettings"));
            services.AddScoped<IJwtTokenService, JwtTokenService>();
        }
    }
}
