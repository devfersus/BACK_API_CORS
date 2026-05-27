using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Aplicacion.Dto;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Aplicacion.Repository;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Dominio.Interface;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarOrdenFoto.Aplicacion
{
    public class SDActualizarOrdenFoto
        (IActualizarOrdenFoto actualizarOrdenFoto)
        : ActualizarOrdenFotoRepository
    {
        public readonly IActualizarOrdenFoto _actualizarOrdenFoto = actualizarOrdenFoto;

        public async Task ActualizarOrdenFoto(ActualizarOrdenFotoDTO dto)
        {
            await _actualizarOrdenFoto.ActualizarOrdenFoto(dto.PropiedadDetalleFotosId, dto.Orden);
        }
    }
}
