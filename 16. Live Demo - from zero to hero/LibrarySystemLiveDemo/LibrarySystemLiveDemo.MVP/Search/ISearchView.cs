using System;
using WebFormsMvp;

namespace LibrarySystemLiveDemo.MVP.Search
{
    public interface ISearchView : IView<SearchViewModel>
    {
        event EventHandler<SearchEventArgs> OnRepeaterGetData;
    }
}
