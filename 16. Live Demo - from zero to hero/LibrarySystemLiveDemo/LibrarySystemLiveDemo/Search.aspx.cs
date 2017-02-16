using System;
using System.Linq;
using System.Web.ModelBinding;
using LibrarySystemLiveDemo.Data.Models;
using LibrarySystemLiveDemo.MVP.Search;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace LibrarySystemLiveDemo
{
    [PresenterBinding(typeof(SearchPresenter))]
    public partial class Search : MvpPage<SearchViewModel>, ISearchView
    {
        public event EventHandler<SearchEventArgs> OnRepeaterGetData;

        public IQueryable<Book> Reapeater_GetData([QueryString] string q)
        {
            this.OnRepeaterGetData?.Invoke(this, new SearchEventArgs(q));

            return this.Model.Books;
        }
    }
}