using COREBAK.TipoPropiedad_.Entidad.Base;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.EliminarTipoPropiedad.Dominio.Interface
{
    public interface IEliminarTipoPropiedad
    {
        public Task EliminarTipoPropiedad(Guid tipoPropiedadId);
    }
}
