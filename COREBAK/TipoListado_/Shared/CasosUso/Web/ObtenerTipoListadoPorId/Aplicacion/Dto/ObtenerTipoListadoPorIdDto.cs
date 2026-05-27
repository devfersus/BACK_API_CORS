namespace COREBAK.TipoListado_.Shared.CasosUso.Web.ObtenerTipoListadoPorId.Aplicacion.Dto
{
    public class ObtenerTipoListadoPorIdDto
    {
        public Guid TipoListadoId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
