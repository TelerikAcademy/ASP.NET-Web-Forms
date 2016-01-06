using System;
using System.Data.Entity;
using System.Linq;
using System.Web.UI;

namespace ModelBindingDemo
{
    public partial class ModelBindingExample : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GridViewProducts_GetData()
        {
            NorthwindEntities context = new NorthwindEntities();
            return context.Products.
                Include("Supplier").Include("Category").
                OrderBy(p => p.ProductID);
        }

        public void GridViewProducts_UpdateItem(int productID)
        {
            NorthwindEntities context = new NorthwindEntities();
            Product product = context.Products.Find(productID);
            if (product == null)
            {
                // The item wasn't found
                ModelState.AddModelError("",
                    String.Format("Product with id {0} was not found", productID));
                return;
            }
            TryUpdateModel(product);
            if (ModelState.IsValid)
            {
                context.Entry(product).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}