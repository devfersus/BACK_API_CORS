using COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Aplicacion.Dto;
using COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Aplicacion.Repository;
using COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Dominio.Interface;
using COREBAK.TipoPropiedad_.Entidad.Base;
using COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Aplicacion;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.ActualizarTipoPropiedad.Aplicacion
{
    public class ServicioAplicacion
        (
            IActualizarTipoPropiedad ActualizarTipoPropiedad,
            SAValidarRegistroRelacionadoPropiedadDetalle validarRegistroRelacionado
        ) : ActualizarTipoPropiedadRepository
    {
        public readonly IActualizarTipoPropiedad _actualizarTipoPropiedad = ActualizarTipoPropiedad;
        public readonly SAValidarRegistroRelacionadoPropiedadDetalle _validarRegistroRelacionado = validarRegistroRelacionado;

        public async Task ActualizarTipoPropiedad(ActualizarTipoPropiedadDTO actualizarTipoPropiedadDTO)
        {
            if (!actualizarTipoPropiedadDTO.Activo)
                await _validarRegistroRelacionado.EjecutarAsync(actualizarTipoPropiedadDTO.Id);

            TipoPropiedad tipoPropiedad = new TipoPropiedad(

                tipoPropiedadId : actualizarTipoPropiedadDTO.Id,
                descripcion     : actualizarTipoPropiedadDTO.Descripcion,
                activo          : actualizarTipoPropiedadDTO.Activo

            );

            await _actualizarTipoPropiedad.ActualizarTipoPropiedad(tipoPropiedad);
        }
    }
}
