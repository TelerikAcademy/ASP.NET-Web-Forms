using EmployeesLiveDemoWithMvpAndNinject.Models;
using EmployeesLiveDemoWithMvpAndNinject.Presenters;
using EmployeesLiveDemoWithMvpAndNinject.Views;
using System;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace EmployeesLiveDemoWithMvpAndNinject
{
    [PresenterBinding(typeof(EmpDetailsPresenter))]
    public partial class EmpDetails : MvpPage<EmployeeViewModel>, IEmpDetailsView
    {
        public event EventHandler<EmpDetailsEventArgs> MyInit;

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(this.Request.QueryString["id"]);
            this.MyInit?.Invoke(sender, new EmpDetailsEventArgs(id));

            this.DetailsView.DataSource = this.Model.Employees;
            this.DetailsView.DataBind();
        }
    }
}