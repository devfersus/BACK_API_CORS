using COREBAK.TipoPropiedad_.Entidad.Base;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Dominio.Interface
{
    public interface IRegistrarTipoPropiedad
    {
        public Task RegistrarTipoPropiedad(TipoPropiedad tipoPropiedad);
    }
}