using COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Aplicacion.Dto;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Aplicacion.Repository;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Dominio.Interface;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ActivarDesactivarFoto.Aplicacion
{
    public class SDActivarDesactivarFoto
        (IActivarDesactivarFoto activarDesactivarFoto)
        : ActivarDesactivarFotoRepository
    {
        public readonly IActivarDesactivarFoto _activarDesactivarFoto = activarDesactivarFoto;

        public async Task ActivarDesactivarFoto(ActivarDesactivarFotoDTO dto)
        {
            await _activarDesactivarFoto.ActivarDesactivarFoto(dto.PropiedadDetalleFotosId, dto.Activo);
        }
    }
}
