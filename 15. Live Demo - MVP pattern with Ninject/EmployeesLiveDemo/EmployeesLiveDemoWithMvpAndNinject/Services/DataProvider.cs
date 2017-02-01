using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesLiveDemoWithMvpAndNinject.Services
{
    public class DataProvider : IDataProvider
    {
        private readonly IDbContext dbContext;

        public DataProvider(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return this.dbContext.Employees.ToList();
        }

        public IEnumerable<Employee> GetEmployeesById(int id)
        {
            return this.dbContext.Employees.Where(em => em.EmployeeID == id).ToList();
        }
    }
}