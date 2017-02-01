using EmployeesLiveDemoWithMvpAndNinject.Models;
using EmployeesLiveDemoWithMvpAndNinject.Presenters;
using EmployeesLiveDemoWithMvpAndNinject.Views;
using System;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace EmployeesLiveDemoWithMvpAndNinject
{
    [PresenterBinding(typeof(EmployeePresenter))]
    public partial class Employee : MvpPage<EmployeeViewModel>, IEmployeeView
    {
        public event EventHandler MailSend;
        public event EventHandler MyInit;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.MyInit?.Invoke(sender, e);

            this.GridView1.DataSource = this.Model.Employees;
            this.GridView1.DataBind();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            this.MailSend?.Invoke(sender, e);
        }
    }
}