using System;
using System.Linq;
using LibrarySystemLiveDemo.Data;
using LibrarySystemLiveDemo.Data.Models;

namespace LibrarySystemLiveDemo.Services
{
    public class BookService : IBookService
    {
        private readonly ILibrarySystemContext librarySystemContext;

        public BookService(ILibrarySystemContext librarySystemContext)
        {
            this.librarySystemContext = librarySystemContext;
        }

        public IQueryable<Book> GetBooksByTitleOrAuthor(string searchTerm)
        {
            return string.IsNullOrEmpty(searchTerm) ? this.librarySystemContext.Books
                : this.librarySystemContext.Books.Where(b => 
                (string.IsNullOrEmpty(b.Title) ?  false : b.Title.Contains(searchTerm)) 
                || 
                (string.IsNullOrEmpty(b.Author) ? false : b.Author.Contains(searchTerm)));
        }

        public Book GetById(Guid? id)
        {
            return id.HasValue ? this.librarySystemContext.Books.Find(id) : null;
        }
    }
}