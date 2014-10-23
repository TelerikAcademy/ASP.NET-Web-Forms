using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem
{
    public partial class BookDetails : System.Web.UI.Page
    {
        public LibraryDbContext dbContext;

        public BookDetails()
        {
            this.dbContext = new LibraryDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public LibrarySystem.Models.Book FormViewBookDetails_GetItem([QueryString("id")]int? bookID)
        {
            if (bookID == null)
            {
                Response.Redirect("~/");
            }

            var book = this.dbContext.Books.FirstOrDefault(b => b.ID == bookID);
            return book;
        }
    }
}