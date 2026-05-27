namespace COREBAK.TipoPropiedad_.Shared.CasosUso.Web.ObtenerTipoPropiedadPorId.Aplicacion.Dto
{
    public class ObtenerTipoPropiedadPorIdDto
    {
        public Guid TipoPropiedadId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}