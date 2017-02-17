using System;
using Bytes2you.Validation;
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
            this.View.OnDeleteItem += this.View_OnDeleteItem;
            this.View.OnUpdateItem += this.View_OnUpdateItem;
        }

        private void View_OnUpdateItem(object sender, IdEventArgs e)
        {
            Category item = this.categoryService.GetById(e.Id);
            if (item == null)
            {
                // The item wasn't found
                this.View.ModelState.
                    AddModelError("", String.Format("Item with id {0} was not found", e.Id));
                return;
            }

            this.View.TryUpdateModel(item);
            if (this.View.ModelState.IsValid)
            {
                this.categoryService.UpdateCategory(item);
            }
        }

        private void View_OnDeleteItem(object sender, IdEventArgs e)
        {
            this.categoryService.DeleteCategory(e.Id);
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