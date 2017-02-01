using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesLiveDemoWithMvpAndNinject.Services
{
    public interface IDataProvider
    {
        IEnumerable<Employee> GetEmployees();

        IEnumerable<Employee> GetEmployeesById(int id);
    }
}