using LibrarySystemLiveDemo.Services;
using WebFormsMvp;

namespace LibrarySystemLiveDemo.MVP.BookDetails
{
    public class BookDetailsPresenter : Presenter<IBookDetailsView>
    {
        private readonly IBookService bookService;

        public BookDetailsPresenter(IBookDetailsView view, IBookService bookService) 
            : base(view)
        {
            this.bookService = bookService;

            this.View.OnFormGetItems += this.View_OnFormGetItems;
        }

        private void View_OnFormGetItems(object sender, FormGetItemsEventArgs e)
        {
            this.View.Model.Book = this.bookService.GetById(e.Id);
        }
    }
}