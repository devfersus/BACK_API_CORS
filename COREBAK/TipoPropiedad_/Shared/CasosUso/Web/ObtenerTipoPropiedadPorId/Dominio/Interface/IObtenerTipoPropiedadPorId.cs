using COREBAK.TipoPropiedad_.Entidad.Base;

namespace COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Dominio.Interface
{
    public interface IObtenerTipoPropiedadPorId
    {
        public Task<TipoPropiedad> ObtenerPorIdAsync(Guid tipoPropiedadId);
    }
}