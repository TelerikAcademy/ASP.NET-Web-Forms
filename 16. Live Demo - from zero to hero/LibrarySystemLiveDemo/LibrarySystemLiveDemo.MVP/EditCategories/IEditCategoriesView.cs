using System;
using System.Web.ModelBinding;
using WebFormsMvp;

namespace LibrarySystemLiveDemo.MVP.EditCategories
{
    public interface IEditCategoriesView : IView<EditCategoriesViewModel>
    {
        event EventHandler OnGetData;
        event EventHandler OnInsertItem;
        event EventHandler<IdEventArgs> OnDeleteItem;
        event EventHandler<IdEventArgs> OnUpdateItem;

        ModelStateDictionary ModelState { get; }

        bool TryUpdateModel<TModel>(TModel model) where TModel : class;
    }
}