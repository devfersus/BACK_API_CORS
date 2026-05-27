using COREBAK.PropiedadDetalle_.Entidad.Base;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Dominio.Interface
{
    public interface IRegistrarPropiedadDetalle
    {
        Task registrarPropiedadDetalle(PropiedadDetalle propiedadDetalle, List<string> urlsFotos, List<int>? ordenesFotos);
    }
}