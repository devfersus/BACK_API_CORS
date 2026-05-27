using COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Aplicacion.Dto;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Aplicacion.Repository
{
    internal interface ActivarDesactivarFotoRepository
    {
        Task ActivarDesactivarFoto(ActivarDesactivarFotoDTO dto);
    }
}
