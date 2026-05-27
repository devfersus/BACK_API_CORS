using COREBAK.Departamento_.Entidad.Base;

namespace COREBAK.Departamento_.Shared.CasosUso.Web.ObtenerDepartamentoPorId.Dominio.Interface
{
    public interface IObtenerDepartamentoPorId
    {
        Task<Departamento?> ObtenerPorIdAsync(int departamentoId);
    }
}
