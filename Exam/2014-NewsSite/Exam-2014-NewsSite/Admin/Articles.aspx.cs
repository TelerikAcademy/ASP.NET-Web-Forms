using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using NewsSite.Models;
using System.Web.ModelBinding;
using System.Linq.Expressions;
using System.Linq.Dynamic;
using System.Reflection;

namespace NewsSite.Admin
{
    public partial class Articles : BasePage
    {
        private bool changeDirection = false;

        public SortDirection SortDirection
        {
            get
            {
                SortDirection direction = SortDirection.Ascending;
                if (ViewState["sortdirection"] != null)
                {
                    if ((SortDirection)ViewState["sortdirection"] == SortDirection.Descending &&
                        !this.changeDirection ||
                        (SortDirection)ViewState["sortdirection"] == SortDirection.Ascending &&
                        this.changeDirection)
                    {
                        direction = SortDirection.Descending;
                    }
                }

                ViewState["sortdirection"] = direction;
                return direction;
            }
            set
            {
                ViewState["sortdirection"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListViewArticles_Sorting(object sender, ListViewSortEventArgs e)
        {
            e.Cancel = true;
            if (ViewState["OrderBy"] != null &&
                (string)ViewState["OrderBy"] == e.SortExpression)
            {
                this.changeDirection = true;
            }
            else
            {
                this.SortDirection = SortDirection.Ascending;
            }

            ViewState["OrderBy"] = e.SortExpression;
            this.ListViewArticles.DataBind();
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<NewsSite.Models.Article> ListViewArticles_GetData([ViewState("OrderBy")]String OrderBy = null)
        {
            var articles = this.dbContext.Articles.AsQueryable();
            if (OrderBy != null)
            {
                switch (this.SortDirection)
                {
                    case SortDirection.Ascending:
                        articles = articles.OrderBy(OrderBy);
                        break;
                    case SortDirection.Descending:
                        articles = articles.OrderBy(OrderBy + " Descending");
                        break;
                    default:
                        articles = articles.OrderBy(OrderBy + " Descending");
                        break;
                }
                return articles;
            }
            else
            {
                articles.OrderBy("DateCreated Descending");
            }


            return articles;
        }

        public void ListViewArticles_InsertItem()
        {
            var item = new NewsSite.Models.Article();
            item.DateCreated = DateTime.Now;
            item.AuthorID = User.Identity.GetUserId();

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                this.dbContext.Articles.Add(item);
                this.dbContext.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewArticles_UpdateItem(int id)
        {
            NewsSite.Models.Article item = this.dbContext.Articles.Find(id);
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
        public void ListViewArticles_DeleteItem(int id)
        {
            NewsSite.Models.Article item = this.dbContext.Articles.Find(id);
            this.dbContext.Articles.Remove(item);
            this.dbContext.SaveChanges();
        }

        public IQueryable<Category> DropDownListCategories_GetData()
        {
            return this.dbContext.Categories.OrderBy(c => c.Name);
        }
    }

    //public static class LinqExtensions
    //{
    //    public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, string property)
    //    {
    //        return ApplyOrder<T>(source, property, "OrderBy");
    //    }
    //    public static IOrderedQueryable<T> OrderByDescending<T>(this IQueryable<T> source, string property)
    //    {
    //        return ApplyOrder<T>(source, property, "OrderByDescending");
    //    }
    //    public static IOrderedQueryable<T> ThenBy<T>(this IOrderedQueryable<T> source, string property)
    //    {
    //        return ApplyOrder<T>(source, property, "ThenBy");
    //    }
    //    public static IOrderedQueryable<T> ThenByDescending<T>(this IOrderedQueryable<T> source, string property)
    //    {
    //        return ApplyOrder<T>(source, property, "ThenByDescending");
    //    }
    //    static IOrderedQueryable<T> ApplyOrder<T>(IQueryable<T> source, string property, string methodName)
    //    {
    //        string[] props = property.Split('.');
    //        Type type = typeof(T);
    //        ParameterExpression arg = Expression.Parameter(type, "x");
    //        Expression expr = arg;
    //        foreach (string prop in props)
    //        {
    //            // use reflection (not ComponentModel) to mirror LINQ
    //            PropertyInfo pi = type.GetProperty(prop);
    //            expr = Expression.Property(expr, pi);
    //            type = pi.PropertyType;
    //        }
    //        Type delegateType = typeof(Func<,>).MakeGenericType(typeof(T), type);
    //        LambdaExpression lambda = Expression.Lambda(delegateType, expr, arg);

    //        object result = typeof(Queryable).GetMethods().Single(
    //                method => method.Name == methodName
    //                        && method.IsGenericMethodDefinition
    //                        && method.GetGenericArguments().Length == 2
    //                        && method.GetParameters().Length == 2)
    //                .MakeGenericMethod(typeof(T), type)
    //                .Invoke(null, new object[] { source, lambda });
    //        return (IOrderedQueryable<T>)result;
    //    }
    //}

}