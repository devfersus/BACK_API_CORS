using COREBAK.Departamento_.Entidad.Base;

namespace COREBAK.Departamento_.CasosUso.Web.RegistrarDepartamento.Dominio.Interface
{
    public interface IRegistrarDepartamento
    {
        public Task RegistrarDepartamento(Departamento departamento);
    }
}
