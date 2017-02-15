using System;
using WebFormsMvp;

namespace LibrarySystemLiveDemo.MVP.BookDetails
{
    public interface IBookDetailsView : IView<BookDetailsViewModel>
    {
        event EventHandler<FormGetItemsEventArgs> OnFormGetItems;
    }
}