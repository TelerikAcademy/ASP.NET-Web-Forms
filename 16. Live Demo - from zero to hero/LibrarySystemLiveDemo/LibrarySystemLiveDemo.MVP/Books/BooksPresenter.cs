using System;
using LibrarySystemLiveDemo.Services;
using WebFormsMvp;

namespace LibrarySystemLiveDemo.MVP.Books
{
    public class BooksPresenter : Presenter<IBooksView>
    {
        private readonly ICategoryService categoryService;

        public BooksPresenter(IBooksView view, ICategoryService categoryService) 
            : base(view)
        {
            this.categoryService = categoryService;

            this.View.OnCategoriesGetData += this.View_OnCategoriesGetData;
        }

        private void View_OnCategoriesGetData(object sender, EventArgs e)
        {
            this.View.Model.Categories = this.categoryService.GetAllCategoriesWithBooksIncluded();
        }
    }
}