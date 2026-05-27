namespace COREBAK.Usuario_.Entidad.Base
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public bool Activo { get; set; }
        public string? Token { get; set; }
        public DateTime? TokenExpiracion { get; set; }

        public Usuario() { }

        public Usuario(Guid usuarioId, string nombreUsuario, string contrasena, bool activo)
        {
            UsuarioId = usuarioId;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Activo = activo;
        }
    }
}
