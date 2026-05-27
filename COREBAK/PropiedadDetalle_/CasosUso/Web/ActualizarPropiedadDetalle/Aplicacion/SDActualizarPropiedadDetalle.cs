using COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Aplicacion.Dto;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Aplicacion.Repository;
using COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Dominio.Interface;
using COREBAK.PropiedadDetalle_.Entidad.Base;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.ActualizarPropiedadDetalle.Aplicacion
{
    public class SDActualizarPropiedadDetalle
        (IActualizarPropiedadDetalle actualizarPropiedadDetalle)
        : ActualizarPropiedadDetalleRepository
    {
        public readonly IActualizarPropiedadDetalle _actualizarPropiedadDetalle = actualizarPropiedadDetalle;

        public async Task ActualizarPropiedadDetalle(ActualizarPropiedadDetalleDTO dto)
        {

            PropiedadDetalle propiedadDetalle = new PropiedadDetalle(
                propiedadListadoId: dto.PropiedadListadoId,
                tipoPropiedadId: dto.TipoPropiedadId,
                tipoListadoId: dto.TipoListadoId,
                titulo: dto.Titulo,
                descripcion: dto.Descripcion,
                precio: dto.Precio,
                codigoPromocionId: dto.CodigoPromocionId,
                activo: dto.Activo,
                departamentoId: dto.DepartamentoId,
                descripcionFinal: dto.DescripcionFinal,
                orden: dto.Orden,
                ubicacion: dto.Ubicacion,
                areaTerreno: dto.AreaTerreno,
                tipoMoneda: dto.TipoMoneda
            );
            await _actualizarPropiedadDetalle.actualizarPropiedadDetalle(propiedadDetalle);
        }
    }
}