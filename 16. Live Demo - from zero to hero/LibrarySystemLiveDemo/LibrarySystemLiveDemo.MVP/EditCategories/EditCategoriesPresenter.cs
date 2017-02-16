using System;
using Bytes2you.Validation;
using LibrarySystemLiveDemo.Data;
using LibrarySystemLiveDemo.Data.Models;
using LibrarySystemLiveDemo.Services;
using WebFormsMvp;

namespace LibrarySystemLiveDemo.MVP.EditCategories
{
    public class EditCategoriesPresenter : Presenter<IEditCategoriesView>
    {
        private readonly ICategoryService categoryService;

        public EditCategoriesPresenter(IEditCategoriesView view, ICategoryService categoryService) 
            : base(view)
        {
            Guard.WhenArgument(categoryService, "categoryService").IsNull().Throw();

            this.categoryService = categoryService;

            this.View.OnGetData += this.View_OnGetData;
            this.View.OnInsertItem += this.View_OnInsertItem;
        }

        private void View_OnInsertItem(object sender, EventArgs e)
        {
            Category category = new Category();
            this.View.TryUpdateModel(category);
            if (this.View.ModelState.IsValid)
            {
                this.categoryService.InsertCategory(category);
            }
        }

        private void View_OnGetData(object sender, EventArgs e)
        {
            this.View.Model.Categories = this.categoryService.GetAllCategoriesSortedById();
        }
    }
}