using System;
using WebFormsMvp;

namespace EmployeesLiveDemoWithMvpAndNinject.Factories
{
    public interface ICustomPresenterFactory
    {
        IPresenter GetPresenter(Type presenterType, IView viewInstance);
    }
}