namespace COREBAK.Departamento_.Entidad.Base
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public Departamento(
             int departamentoId
            , string descripcion
            , bool activo
            )
        {
            DepartamentoId = departamentoId;
            Descripcion = descripcion;
            Activo = activo;
        }

        public void ActualizarDepartamento(int departamentoId, string descripcion, bool activo)
        {
            DepartamentoId = departamentoId;
            Descripcion = descripcion;
            Activo = activo;
        }
    }
}
