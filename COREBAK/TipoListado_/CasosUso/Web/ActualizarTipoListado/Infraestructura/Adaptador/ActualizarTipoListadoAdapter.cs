using COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Dominio.Interface;
using COREBAK.TipoListado_.Entidad.Base;
using COREBAK.TipoListado_.Entidad.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.TipoListado_.CasosUso.Web.ActualizarTipoListado.Infraestructura.Adaptador
{
    public class ActualizarTipoListadoAdapter : IActualizarTipoListado
    {
        public readonly TipoListadoDataBaseContext _context;

        public ActualizarTipoListadoAdapter(TipoListadoDataBaseContext context)
        {
            _context = context;
        }

        public async Task ActualizarTipoListado(TipoListado tipoListado)
        {
            var registro = await _context.TipoListadoDBContext
                .FirstOrDefaultAsync(TipoListado => TipoListado.TipoListadoId == tipoListado.TipoListadoId);

            if (registro == null)
                throw new Exception("Tipo de listado no encontrado.");

            registro.actualizarTipoListado(
                tipoListado.TipoListadoId,
                tipoListado.Descripcion,
                tipoListado.Activo
            );

            await _context.SaveChangesAsync();
        }
    }
}