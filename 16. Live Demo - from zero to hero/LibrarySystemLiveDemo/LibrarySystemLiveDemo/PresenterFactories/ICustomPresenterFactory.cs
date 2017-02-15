using System;
using WebFormsMvp;

namespace LibrarySystemLiveDemo.PresenterFactories
{
    public interface ICustomPresenterFactory
    {
        IPresenter GetPresenter(Type presenterType, IView viewInstance);
    }
}