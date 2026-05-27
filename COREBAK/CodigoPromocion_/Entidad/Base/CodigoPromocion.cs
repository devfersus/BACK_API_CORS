namespace COREBAK.CodigoPromocion_.Entidad.Base
{
    public class CodigoPromocion
    {
        public int CodigoPromocionId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }

        public CodigoPromocion(
            int codigoPromocionId,
            string descripcion,
            bool activo,
            DateTime fechaRegistro,
            string usuarioRegistro)
        {
            CodigoPromocionId = codigoPromocionId;
            Descripcion       = descripcion;
            Activo            = activo;
            FechaRegistro     = fechaRegistro;
            UsuarioRegistro   = usuarioRegistro;
        }

        public void Actualizar(string descripcion, bool activo)
        {
            Descripcion = descripcion;
            Activo      = activo;
        }
    }
}
