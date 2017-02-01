using System.Data.Entity;

namespace EmployeesLiveDemoWithMvpAndNinject.Services
{
    public class MyNorthwindDbContext : NorthwindEntities, IDbContext
    {
        public IDbSet<Employee> Employees
        {
            get
            {
                return base.Employees;
            }
        }
    }
}