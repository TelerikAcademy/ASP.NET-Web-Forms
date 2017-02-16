using System;
using System.Linq;
using LibrarySystemLiveDemo.Data.Models;
using LibrarySystemLiveDemo.MVP.EditCategories;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace LibrarySystemLiveDemo.Admin
{
    [PresenterBinding(typeof(EditCategoriesPresenter))]
    public partial class EditCategories : MvpPage<EditCategoriesViewModel>, IEditCategoriesView
    {
        public event EventHandler OnGetData;
        public event EventHandler OnInsertItem;

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Category> ListView1_GetData()
        {
            this.OnGetData?.Invoke(this, null);

            return this.Model.Categories;
        }

        public void ListView1_InsertItem()
        {
            this.OnInsertItem?.Invoke(this, null);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListView1_DeleteItem(Guid id)
        {

        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListView1_UpdateItem(Guid id)
        {
            LibrarySystemLiveDemo.Data.Models.Category item = null;
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();

            }
        }
    }
}