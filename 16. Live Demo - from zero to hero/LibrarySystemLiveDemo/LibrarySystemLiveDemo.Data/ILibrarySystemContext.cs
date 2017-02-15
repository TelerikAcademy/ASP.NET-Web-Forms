using System.Data.Entity;
using LibrarySystemLiveDemo.Data.Models;

namespace LibrarySystemLiveDemo.Data
{
    public interface ILibrarySystemContext
    {
        IDbSet<Book> Books { get; } 

        IDbSet<Category> Categories { get; }

        int SaveChanges();
    }
}