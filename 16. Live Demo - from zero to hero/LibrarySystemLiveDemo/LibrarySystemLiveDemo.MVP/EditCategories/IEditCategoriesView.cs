using System;
using System.Web.ModelBinding;
using WebFormsMvp;

namespace LibrarySystemLiveDemo.MVP.EditCategories
{
    public interface IEditCategoriesView : IView<EditCategoriesViewModel>
    {
        event EventHandler OnGetData;
        event EventHandler OnInsertItem;

        ModelStateDictionary ModelState { get; }

        bool TryUpdateModel<TModel>(TModel model) where TModel : class;
    }
}