using EmployeesLiveDemoWithMvpAndNinject.Models;
using System;
using WebFormsMvp;

namespace EmployeesLiveDemoWithMvpAndNinject.Views
{
    public interface IEmpDetailsView : IView<EmployeeViewModel>
    {
        event EventHandler<EmpDetailsEventArgs> MyInit;
    }
}