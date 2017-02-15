using System.Linq;
using LibrarySystemLiveDemo.Data.Models;

namespace LibrarySystemLiveDemo.MVP.Books
{
    public class BooksViewModel
    {
        public IQueryable<Category> Categories { get; set; }
    }
}