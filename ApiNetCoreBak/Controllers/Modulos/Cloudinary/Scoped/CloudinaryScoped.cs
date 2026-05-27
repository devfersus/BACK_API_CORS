using COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Aplicacion;
using COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Dominio.Interface;
using COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Infraestructura.Adaptador;

namespace ApiNetCoreBak.Controllers.Modulos.Cloudinary.Scoped
{
    public static class CloudinaryScoped
    {
        public static void AddCloudinaryScoped(this IServiceCollection services)
        {
            services.AddScoped<ISubirFoto, SubirFotoAdapter>();
            services.AddScoped<SDSubirFoto>();
        }
    }
}
