using EmployeesLiveDemoWithMvpAndNinject.Presenters;
using EmployeesLiveDemoWithMvpAndNinject.Services;
using Ninject.Modules;
using Ninject.Web.Common;

namespace EmployeesLiveDemoWithMvpAndNinject.App_Start
{
    public class EmployessNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IDbContext>().To<MyNorthwindDbContext>().InRequestScope();

            this.Bind<EmployeePresenter>().ToSelf();
            this.Bind<EmpDetailsPresenter>().ToSelf();

            this.Bind<IDataProvider>().To<DataProvider>();
            this.Bind<IMailSender>().To<MailSender>();
        }
    }
}