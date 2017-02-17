using System.Data.Entity;
using LibrarySystemLiveDemo.Data.Models;
using System.Data.Entity.Infrastructure;

namespace LibrarySystemLiveDemo.Data
{
    public interface ILibrarySystemContext : ILibrarySystemBaseContext
    {
        IDbSet<Book> Books { get; } 

        IDbSet<Category> Categories { get; }

        DbEntityEntry Entry(object entity);
    }
}