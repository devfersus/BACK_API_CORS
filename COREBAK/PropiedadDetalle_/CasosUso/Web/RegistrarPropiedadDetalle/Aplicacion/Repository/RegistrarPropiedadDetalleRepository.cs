using COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Aplicacion.Dto;
using Microsoft.AspNetCore.Http;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Aplicacion.Repository
{
    internal interface RegistrarPropiedadDetalleRepository
    {
        Task RegistrarPropiedadDetalle(RegistrarPropiedadDetalleDTO registrarPropiedadDetalleDTO);
    }
}
