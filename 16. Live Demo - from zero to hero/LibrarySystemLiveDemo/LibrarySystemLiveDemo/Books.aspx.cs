using System;
using System.Linq;
using LibrarySystemLiveDemo.Data.Models;
using LibrarySystemLiveDemo.MVP.Books;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace LibrarySystemLiveDemo
{
    [PresenterBinding(typeof(BooksPresenter))]
    public partial class Books : MvpPage<BooksViewModel>, IBooksView
    {
        public event EventHandler OnCategoriesGetData;

        public IQueryable<Category> ListViewCategories_GetData()
        {
            this.OnCategoriesGetData?.Invoke(this, null);

            return this.Model.Categories;
        }

        protected void LinkButtonSearch_Click(object sender, EventArgs e)
        {
            string textToSearchFor = this.TextBoxSearchParam.Text;
            string queryParam = string.IsNullOrEmpty(textToSearchFor) ? string.Empty : string.Format("?q={0}", textToSearchFor);
            Response.Redirect("~/search" + queryParam);
        }
    }
}