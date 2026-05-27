using COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Aplicacion.Dto;
using COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Aplicacion.Repository;
using COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Dominio.Interface;
using COREBAK.TipoListado_.Entidad.Base;
using COREBAK.TipoListado_.Shared.CasosUso.Web.ValidarRegistroRelacionadoPropiedadDetalle.Aplicacion;

namespace COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Aplicacion
{
    public class SDTipoListadoActualizar
        (
            IActualizarTipoListado actualizarTipoListado,
            SAValidarRegistroRelacionadoPropiedadDetalle validarRegistroRelacionado
        )
        : ActualizarTipoListadoRepository
    {
        public readonly IActualizarTipoListado _ActualizarTipoListado = actualizarTipoListado;
        public readonly SAValidarRegistroRelacionadoPropiedadDetalle _validarRegistroRelacionado = validarRegistroRelacionado;

        public async Task ActualizarTipoListado(ActualizarTipoListadoDTO actualizarTipoListadoDTO)
        {
            if (!actualizarTipoListadoDTO.Activo)
                await _validarRegistroRelacionado.EjecutarAsync(actualizarTipoListadoDTO.TipoListadoId);

            TipoListado tipoListado = new TipoListado(
                tipoListadoId: actualizarTipoListadoDTO.TipoListadoId,
                descripcion: actualizarTipoListadoDTO.Descripcion,
                activo: actualizarTipoListadoDTO.Activo
            );
            await _ActualizarTipoListado.ActualizarTipoListado(tipoListado);
        }
    }
}