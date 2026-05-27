using COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Aplicacion;
using COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Dominio.Interface;
using COREBAK.Departamento_.CasosUso.Web.ActualizarDepartamento.Infraestructura.Adaptador;
using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Aplicacion;
using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Dominio.Interface;
using COREBAK.Departamento_.CasosUso.Web.ListarDepartamento.Infraestructura.Adaptador;
using COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Aplicacion;
using COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Dominio.Interface;
using COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Infraestructura.Adaptador;
using COREBAK.Departamento_.Entidad.DataBaseContext;
using COREBAK.Departamento_.Shared.CasosUso.Web.ObtenerDepartamentoPorId.Aplicacion;
using COREBAK.Departamento_.Shared.CasosUso.Web.ObtenerDepartamentoPorId.Dominio.Interface;
using COREBAK.Departamento_.Shared.CasosUso.Web.ObtenerDepartamentoPorId.Infraestructura.Adaptador;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreBak.Controllers.Modulos.ImbPiura.Departamento.Scoped
{
    public static class DepartamentoScoped
    {
        public static void AddDepartamentoScoped(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DepartamentoDataBaseContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRegistrarDepartamento, RegistrarDepartamentoAdapter>();
            services.AddScoped<IListarDepartamento, ListarDepartamentoAdapter>();
            services.AddScoped<IActualizarDepartamento, ActualizarDepartamentoAdapter>();

            services.AddScoped<IObtenerDepartamentoPorId, ObtenerDepartamentoPorIdAdapter>();

            services.AddScoped<SDRegistrarDepartamento>();
            services.AddScoped<SDListarDepartamento>();
            services.AddScoped<SDActualizarDepartamento>();
            services.AddScoped<SAObtenerDepartamentoPorId>();
        }
    }
}
