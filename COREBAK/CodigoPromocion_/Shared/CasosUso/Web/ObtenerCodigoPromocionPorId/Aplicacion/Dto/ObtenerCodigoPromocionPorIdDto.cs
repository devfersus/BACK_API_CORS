namespace COREBAK.CodigoPromocion_.Shared.CasosUso.Web.ObtenerCodigoPromocionPorId.Aplicacion.Dto
{
    public class ObtenerCodigoPromocionPorIdDto
    {
        public int CodigoPromocionId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
