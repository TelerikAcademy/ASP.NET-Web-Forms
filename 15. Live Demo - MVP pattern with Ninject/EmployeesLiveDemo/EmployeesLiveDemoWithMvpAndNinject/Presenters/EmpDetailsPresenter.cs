using EmployeesLiveDemoWithMvpAndNinject.Models;
using EmployeesLiveDemoWithMvpAndNinject.Services;
using EmployeesLiveDemoWithMvpAndNinject.Views;
using WebFormsMvp;

namespace EmployeesLiveDemoWithMvpAndNinject.Presenters
{
    public class EmpDetailsPresenter : Presenter<IEmpDetailsView>
    {
        private readonly IDataProvider provider;

        public EmpDetailsPresenter(IEmpDetailsView view, IDataProvider provider)
            : base(view)
        {
            this.provider = provider;

            this.View.MyInit += this.View_MyInit;
        }

        private void View_MyInit(object sender, EmpDetailsEventArgs e)
        {
            this.View.Model.Employees = this.provider.GetEmployeesById(e.Id);
        }
    }
}