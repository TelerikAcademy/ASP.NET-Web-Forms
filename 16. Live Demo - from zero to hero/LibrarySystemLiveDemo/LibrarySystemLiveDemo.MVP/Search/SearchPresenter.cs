using Bytes2you.Validation;
using LibrarySystemLiveDemo.Services;
using WebFormsMvp;

namespace LibrarySystemLiveDemo.MVP.Search
{
    public class SearchPresenter : Presenter<ISearchView>
    {
        private readonly IBookService bookService;

        public SearchPresenter(ISearchView view, IBookService bookService) 
            : base(view)
        {
            Guard.WhenArgument(bookService, "bookService").IsNull().Throw();

            this.bookService = bookService;

            this.View.OnRepeaterGetData += this.View_OnRepeaterGetData;
        }

        private void View_OnRepeaterGetData(object sender, SearchEventArgs e)
        {
            this.View.Model.Books = this.bookService.GetBooksByTitleOrAuthor(e.QueryParams);
        }
    }
}