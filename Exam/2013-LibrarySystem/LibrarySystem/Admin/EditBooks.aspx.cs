using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem.Admin
{
    public partial class EditBooks : System.Web.UI.Page
    {
        public LibraryDbContext dbContext;

        public EditBooks()
        {
            this.dbContext = new LibraryDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Book> GridViewBooks_GetData()
        {
            return this.dbContext.Books.OrderBy(b => b.ID);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewBooks_UpdateItem(int id)
        {
            Book item = this.dbContext.Books.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                this.dbContext.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewBooks_DeleteItem(int id)
        {
            Book item = this.dbContext.Books.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            this.dbContext.Books.Remove(item);
            this.dbContext.SaveChanges();
        }

        public void FormViewIsertBook_InsertItem()
        {
            var item = new LibrarySystem.Models.Book();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                this.dbContext.Books.Add(item);
                this.dbContext.SaveChanges();
            }
        }
        public IQueryable<Category> DropDownListCategoriesCreate_GetData()
        {
            return this.dbContext.Categories.OrderBy(b => b.Name);
        }

        protected void DropDownListCategoriesCreate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButtonInsert_Click(object sender, EventArgs e)
        {
            this.btnWrapper.Visible = false;

            var fv = this.UpdatePanelInsertBook.FindControl("FormViewIsertBook") as FormView;
            fv.Visible = true;
        }
    }
}