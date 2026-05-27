using COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Aplicacion.Dto;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ListarPropiedadDetalle.Dominio.Interface
{
    public interface IListarPropiedadDetalle
    {
        Task<ListarPropiedadDetallePaginadoDTO> ListarPropiedadDetalle(int numeroPagina, int tamanioPagina);
    }
}