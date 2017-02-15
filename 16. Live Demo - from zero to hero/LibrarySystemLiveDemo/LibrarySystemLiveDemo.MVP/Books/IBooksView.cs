using System;
using WebFormsMvp;

namespace LibrarySystemLiveDemo.MVP.Books
{
    public interface IBooksView : IView<BooksViewModel>
    {
        event EventHandler OnCategoriesGetData;
    }
}