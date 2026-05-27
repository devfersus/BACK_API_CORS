using COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Aplicacion.Repository;
using COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Dominio.Interface;
using Microsoft.AspNetCore.Http;

namespace COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Aplicacion
{
    public class SDSubirFoto
        (ISubirFoto subirFoto)
        : SubirFotoRepository
    {
        public readonly ISubirFoto _subirFoto = subirFoto;

        public async Task<string> subirFoto(IFormFile foto)
        {
            var resultado = await _subirFoto.subirFoto(foto);
            return resultado.urlFoto;
        }
    }
}
