namespace COREBAK.TipoListado_.Entidad.Base
{
    public class TipoListado
    {
        public Guid TipoListadoId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }

        public TipoListado(
             Guid tipoListadoId
            , string descripcion
            , bool activo
            , DateTime fechaRegistro
            , string usuarioRegistro
            )
        {
            this.TipoListadoId = tipoListadoId;
            this.Descripcion = descripcion;
            this.Activo = activo;
            this.FechaRegistro = fechaRegistro;
            this.UsuarioRegistro = usuarioRegistro;
        }

        public TipoListado(
             Guid tipoListadoId
            , string descripcion
            , bool activo
            )
        {
            this.TipoListadoId = tipoListadoId;
            this.Descripcion = descripcion;
            this.Activo = activo;
        }

        public void actualizarTipoListado(Guid tipoListadoId, string descripcion, bool activo)
        {
            this.TipoListadoId = tipoListadoId;
            this.Descripcion = descripcion;
            this.Activo = activo;
        }
    }
}
