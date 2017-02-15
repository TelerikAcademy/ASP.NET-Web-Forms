using System;
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

        public Book GetById(Guid? id)
        {
            return id.HasValue ? this.librarySystemContext.Books.Find(id) : null;
        }
    }
}