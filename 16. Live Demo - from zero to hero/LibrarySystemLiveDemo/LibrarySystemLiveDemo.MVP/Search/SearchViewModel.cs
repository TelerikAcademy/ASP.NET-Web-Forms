using System.Linq;
using LibrarySystemLiveDemo.Data.Models;

namespace LibrarySystemLiveDemo.MVP.Search
{
    public class SearchViewModel
    {
        public IQueryable<Book> Books { get; set; } 
    }
}