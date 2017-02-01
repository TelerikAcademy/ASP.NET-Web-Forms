using EmployeesLiveDemoWithMvpAndNinject.Models;
using System;
using WebFormsMvp;

namespace EmployeesLiveDemoWithMvpAndNinject.Views
{
    public interface IEmployeeView : IView<EmployeeViewModel>
    {
        event EventHandler MyInit;
        event EventHandler MailSend;
    }
}