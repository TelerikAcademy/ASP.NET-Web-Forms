using System;
using System.Linq;
using LibrarySystemLiveDemo.Data.Models;

namespace LibrarySystemLiveDemo.Services
{
    public interface IBookService
    {
        Book GetById(Guid? id);

        IQueryable<Book> GetBooksByTitleAndAuthor(string searchTerm);
    }
}