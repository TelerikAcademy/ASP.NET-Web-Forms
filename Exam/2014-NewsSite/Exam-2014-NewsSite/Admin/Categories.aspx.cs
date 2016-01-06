using NewsSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSite.Admin
{
    public partial class Categories : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<NewsSite.Models.Category> ListViewCategories_GetData()
        {
            return this.dbContext.Categories.OrderBy(c => c.Name);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_DeleteItem(int id)
        {
            Category item = this.dbContext.Categories.Find(id);
            this.dbContext.Categories.Remove(item);
            this.dbContext.SaveChanges();
        }

        public void ListViewCategories_InsertItem()
        {
            var item = new Category();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                try
                {
                    this.dbContext.Categories.Add(item);
                    this.dbContext.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    this.LabelValidation.Text = string.Format("Category {0} already exists", item.Name);
                }
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_UpdateItem(int id)
        {
            Category item = this.dbContext.Categories.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                try
                {
                    this.dbContext.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    this.LabelValidation.Text = string.Format("Category {0} already exists", item.Name);
                }
            }
        }
    }
}