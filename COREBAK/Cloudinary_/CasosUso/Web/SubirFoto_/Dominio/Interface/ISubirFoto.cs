using COREBAK.Cloudinary_.Entidad.Base;
using Microsoft.AspNetCore.Http;

namespace COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Dominio.Interface
{
    public interface ISubirFoto
    {
        Task<SubirFoto> subirFoto(IFormFile foto);
    }
}
