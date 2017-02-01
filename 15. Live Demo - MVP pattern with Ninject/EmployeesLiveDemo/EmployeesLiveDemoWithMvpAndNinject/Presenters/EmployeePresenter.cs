using EmployeesLiveDemoWithMvpAndNinject.Services;
using EmployeesLiveDemoWithMvpAndNinject.Views;
using System;
using WebFormsMvp;

namespace EmployeesLiveDemoWithMvpAndNinject.Presenters
{
    public class EmployeePresenter : Presenter<IEmployeeView>
    {
        private readonly IDataProvider provider;
        private readonly IMailSender mailSender;

        public EmployeePresenter(IEmployeeView view, IDataProvider provider, IMailSender mailSender)
            : base(view)
        {
            this.provider = provider;
            this.mailSender = mailSender;

            this.View.MyInit += this.View_Init;
            this.View.MailSend += this.View_MailSend;
        }

        private void View_Init(object sender, EventArgs e)
        {
            this.View.Model.Employees = this.provider.GetEmployees();
        }

        private void View_MailSend(object sender, EventArgs e)
        {
            this.mailSender.SendMail();
        }
    }
}