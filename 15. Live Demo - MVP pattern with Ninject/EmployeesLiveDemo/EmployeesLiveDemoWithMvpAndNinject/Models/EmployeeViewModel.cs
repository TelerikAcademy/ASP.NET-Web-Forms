using System.Collections.Generic;

namespace EmployeesLiveDemoWithMvpAndNinject.Models
{
    public class EmployeeViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
    }
}