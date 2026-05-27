using COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Aplicacion.Dto;
using COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Aplicacion.Repository;
using COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Dominio.Interface;
using COREBAK.TipoListado_.Entidad.Base;

namespace COREBAK.TipoListado_.CasosUso.Web.RegistrarTipoListado.Aplicacion
{
    public class SDTipoListadoRegistrar
        (IRegistrarTipoListado registrarTipoListado)
        : RegistrarTipoListadoRepository
    {
        public readonly IRegistrarTipoListado _registrarTipoListado = registrarTipoListado;

        public async Task registrarTipoListado(RegistrarTipoListadoDTO registrarTipoListadoDTO)
        {
            TipoListado tipoListado = new TipoListado(
                tipoListadoId: Guid.NewGuid(),
                descripcion: registrarTipoListadoDTO.Descripcion,
                activo: true,
                fechaRegistro: DateTime.UtcNow,
                usuarioRegistro: registrarTipoListadoDTO.UsuarioRegistro
            );
            await _registrarTipoListado.registrarTipoListado(tipoListado);
        }
    }
}