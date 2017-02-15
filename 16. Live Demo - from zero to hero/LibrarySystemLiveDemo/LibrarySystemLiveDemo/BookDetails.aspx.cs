using System;
using System.Web.ModelBinding;
using LibrarySystemLiveDemo.Data.Models;
using LibrarySystemLiveDemo.MVP.BookDetails;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace LibrarySystemLiveDemo
{
    [PresenterBinding(typeof(BookDetailsPresenter))]
    public partial class BookDetails : MvpPage<BookDetailsViewModel>, IBookDetailsView
    {
        public event EventHandler<FormGetItemsEventArgs> OnFormGetItems;

        public Book FormViewBookDetails_GetItem([QueryString] Guid? id)
        {
            this.OnFormGetItems?.Invoke(this, new FormGetItemsEventArgs(id));

            return this.Model.Book;
        }
    }
}