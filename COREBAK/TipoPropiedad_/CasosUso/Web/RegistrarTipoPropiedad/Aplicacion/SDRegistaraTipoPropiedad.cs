using COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Aplicacion.Dto;
using COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Aplicacion.Repository;
using COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Dominio.Interface;
using COREBAK.TipoPropiedad_.Entidad.Base;
using System;

namespace COREBAK.TipoPropiedad_.CasosUso.Web.RegistrarTipoPropiedad.Aplicacion
{
    public class SDRegistaraTipoPropiedad(
        IRegistrarTipoPropiedad registrarTipoPropiedad
    ) : RegistrarTipoPropiedadRepository
    {
        public readonly IRegistrarTipoPropiedad registrarTipoPropiedad = registrarTipoPropiedad;
        public async Task RegistrarTipoPropiedad(RegistrarTipoPropiedadDTO tipoPropiedadDTO)
        {
            var TipoPropiedadId = Guid.NewGuid();
            var fechaRegistro = DateTime.UtcNow;
            string usuarioRegistro = "SISTEMA";

            TipoPropiedad tipoPropiedad = new TipoPropiedad (
              TipoPropiedadId,
              tipoPropiedadDTO.Descripcion,
              tipoPropiedadDTO.Activo = true,
              fechaRegistro,       
              usuarioRegistro
          );
            await registrarTipoPropiedad.RegistrarTipoPropiedad(tipoPropiedad);
        }
    }
}
