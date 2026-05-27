namespace COREBAK.TipoPropiedad_.Entidad.Base
{
    public class TipoPropiedad
    {
        public Guid TipoPropiedadId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }

        public TipoPropiedad(
             Guid tipoPropiedadId
            ,string descripcion
            ,bool activo
            ,DateTime fechaRegistro
            ,string usuarioRegistro
            )
        {
            TipoPropiedadId = tipoPropiedadId;
            Descripcion = descripcion;
            Activo = activo;
            FechaRegistro = fechaRegistro;
            UsuarioRegistro = usuarioRegistro;
        }
        public TipoPropiedad(
             Guid tipoPropiedadId
            , string descripcion
            , bool activo
        )
        {
            TipoPropiedadId = tipoPropiedadId;
            Descripcion = descripcion;
            Activo = activo;
        }
        public void ActualizarTipoPropiedad(Guid tipoPropiedadId, string descripcion, bool activo)
        {
            TipoPropiedadId = tipoPropiedadId;
            Descripcion = descripcion;
            Activo = activo;
        }
    }
}