using COREBAK.TipoPropiedad_.CasosUso.Web.EliminarTipoPropiedad.Aplicacion.Dto;
using COREBAK.TipoPropiedad_.CasosUso.Web.EliminarTipoPropiedad.Aplicacion.Repository;
using COREBAK.TipoPropiedad_.CasosUso.Web.EliminarTipoPropiedad.Dominio.Interface;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.EliminarTipoPropiedad.Aplicacion
{
    public class ServicioAplicacion
        (
            IEliminarTipoPropiedad EliminarTipoPropiedad
        ) : EliminarTipoPropiedadRepository
    {
        public readonly IEliminarTipoPropiedad _eliminarTipoPropiedad = EliminarTipoPropiedad;
        public async Task EliminarTipoPropiedad(EliminarTipoPropiedadDTO eliminarTipoPropiedad)
        {
            await _eliminarTipoPropiedad.EliminarTipoPropiedad(eliminarTipoPropiedad.Id);
        }
    }
}