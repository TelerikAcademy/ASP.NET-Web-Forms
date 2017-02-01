using System.Data.Entity;

namespace EmployeesLiveDemoWithMvpAndNinject.Services
{
    public interface IDbContext
    {
        IDbSet<Employee> Employees { get; }
    }
}