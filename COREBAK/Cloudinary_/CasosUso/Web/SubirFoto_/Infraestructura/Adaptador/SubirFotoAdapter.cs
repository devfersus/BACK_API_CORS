using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Dominio.Interface;
using COREBAK.Cloudinary_.Entidad.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Infraestructura.Adaptador
{
    public class SubirFotoAdapter : ISubirFoto
    {
        private readonly IAmazonS3 _s3Client;
        private readonly string _bucketName;
        private readonly string _publicUrl;

        public SubirFotoAdapter(IConfiguration configuration)
        {
            var accessKey = configuration["CloudflareR2:AccessKeyId"];
            var secretKey = configuration["CloudflareR2:SecretAccessKey"];
            var endpoint  = configuration["CloudflareR2:Endpoint"];
            _bucketName   = configuration["CloudflareR2:BucketName"];
            _publicUrl    = configuration["CloudflareR2:PublicUrl"];

            var config = new AmazonS3Config
            {
                ServiceURL           = endpoint,
                ForcePathStyle       = true,
                AuthenticationRegion = "auto"
            };

            _s3Client = new AmazonS3Client(
                new BasicAWSCredentials(accessKey, secretKey),
                config
            );
        }

        public async Task<SubirFoto> subirFoto(IFormFile foto)
        {
            var extension = Path.GetExtension(foto.FileName);
            var fileName  = $"propiedades/{Guid.NewGuid()}{extension}";

            using var memoryStream = new MemoryStream();
            await foto.CopyToAsync(memoryStream);
            memoryStream.Position = 0;

            var request = new PutObjectRequest
            {
                BucketName            = _bucketName,
                Key                   = fileName,
                InputStream           = memoryStream,
                ContentType           = foto.ContentType,
                DisablePayloadSigning = true
            };

            await _s3Client.PutObjectAsync(request);

            return new SubirFoto($"{_publicUrl}/{fileName}");
        }
    }
}
