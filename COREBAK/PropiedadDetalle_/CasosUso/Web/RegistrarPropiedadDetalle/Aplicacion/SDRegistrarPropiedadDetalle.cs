using COREBAK.Cloudinary_.CasosUso.Web.SubirFoto_.Aplicacion;
using COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Aplicacion.Dto;
using COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Aplicacion.Repository;
using COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Dominio.Interface;
using COREBAK.PropiedadDetalle_.Entidad.Base;

namespace COREBAK.PropiedadDetalle_.CasosUso.Web.RegistrarPropiedadDetalle.Aplicacion
{
    public class SDRegistrarPropiedadDetalle
        (IRegistrarPropiedadDetalle registrarPropiedadDetalle
        , SDSubirFoto subirFoto)

        : RegistrarPropiedadDetalleRepository
    {
        public readonly IRegistrarPropiedadDetalle _registrarPropiedadDetalle = registrarPropiedadDetalle;
        public readonly SDSubirFoto _subirFoto = subirFoto;

        public async Task RegistrarPropiedadDetalle(RegistrarPropiedadDetalleDTO dto)
        {
            var urlsFotos = new List<string>();
            if (dto.Fotos != null && dto.Fotos.Count > 0)
            {
                foreach (var foto in dto.Fotos)
                {
                    var url = await _subirFoto.subirFoto(foto);
                    urlsFotos.Add(url);
                }
            }

            PropiedadDetalle propiedadDetalle = new PropiedadDetalle(
                propiedadListadoId: Guid.NewGuid(),
                tipoPropiedadId: dto.TipoPropiedadId,
                tipoListadoId: dto.TipoListadoId,
                titulo: dto.Titulo,
                descripcion: dto.Descripcion,
                precio: dto.Precio,
                contadorClicks: 0,
                codigoPromocionId: dto.CodigoPromocionId,
                activo: true,
                departamentoId: dto.DepartamentoId,
                descripcionFinal: dto.DescripcionFinal,
                orden: dto.Orden,
                ubicacion: dto.Ubicacion,
                areaTerreno: dto.AreaTerreno,
                tipoMoneda: dto.TipoMoneda
            );
            await _registrarPropiedadDetalle.registrarPropiedadDetalle(propiedadDetalle, urlsFotos, dto.OrdenesFotos);
        }
    }
}