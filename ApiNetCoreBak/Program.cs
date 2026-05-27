using ApiNetCoreBak.Controllers.Modulos.Cloudinary.Scoped;
using ApiNetCoreBak.Controllers.Modulos.ImbPiura.CodigoPromocion.Scoped;
using ApiNetCoreBak.Controllers.Modulos.ImbPiura.Departamento.Scoped;
using ApiNetCoreBak.Controllers.Modulos.ImbPiura.PropiedadDetalle.Scoped;
using ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoListado.Scoped;
using ApiNetCoreBak.Controllers.Modulos.ImbPiura.TipoPropiedad.Scoped;
using ApiNetCoreBak.Controllers.Modulos.ImbPiura.Usuario.Scoped;
using COREBAK.Middleware.Exceptions.Infraestructura.Middleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

    var builder = WebApplication.CreateBuilder(args);
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    builder.Services.AddTipoPropiedadScoped(connectionString);
    builder.Services.AddTipoListadoScoped(connectionString);
    builder.Services.AddPropiedadDetalleScoped(connectionString);
    builder.Services.AddCodigoPromocionScoped(connectionString);
    builder.Services.AddDepartamentoScoped(connectionString);
    builder.Services.AddCloudinaryScoped();
    builder.Services.AddUsuarioScoped(connectionString, builder.Configuration);

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();

    var jwtSecretKey = builder.Configuration["JwtSettings:SecretKey"];

    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.RequireHttpsMetadata = false;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
                ValidateAudience = true,
                ValidAudience = builder.Configuration["JwtSettings:Audience"],
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecretKey)),
                ValidateLifetime = true
            };
        });

    builder.Services.AddAuthorization();

    builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReact", policy =>
    {
        policy.WithOrigins("http://localhost:5173"
                         , "http://localhost:4200") // puerto de Vite
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});



var app = builder.Build();

    app.UseMiddleware<ExceptionHandlingMiddleware>();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

    app.UseCors("AllowReact");

    app.UseAuthentication();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
