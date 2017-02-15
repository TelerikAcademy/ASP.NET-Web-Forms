using System.Data.Entity;
using LibrarySystemLiveDemo.Data.Models;

namespace LibrarySystemLiveDemo.Data
{
    public class LibrarySystemContext : DbContext, ILibrarySystemContext
    {
        public LibrarySystemContext()
            : base("DefaultConnection")
        {
        }

        public IDbSet<Book> Books { get; set; }

        public IDbSet<Category> Categories { get; set; }
    }
}