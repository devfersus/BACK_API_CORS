using Microsoft.AspNetCore.Http;

namespace COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Aplicacion.Repository
{
    public interface SubirFotoRepository
    {
        Task<string> subirFoto(IFormFile foto);
    }
}
