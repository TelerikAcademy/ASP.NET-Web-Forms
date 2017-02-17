using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using System.Data.Entity;
using LibrarySystemLiveDemo.Data.Models;
using LibrarySystemLiveDemo.Services.Tests.Mocks;
using LibrarySystemLiveDemo.Data;

namespace LibrarySystemLiveDemo.Services.Tests.BookServiceTests
{
    [TestFixture]
    public class GetBooksByTitleOrAuthor_Should
    {
        [Test]
        public void ReturnCorrectResults_WhenTitileIsMatching()
        {
            // Arrange
            var context = new Mock<ILibrarySystemContext>();
            var books = GetBooks();
            string searchTerm = "Title 1";
            var expectedResult = books.Where(b => b.Title.Contains(searchTerm)).AsQueryable();
            var bookSetMock = QueryableDbSetMock.GetQueryableMockDbSet(books);
            context.Setup(c => c.Books).Returns(bookSetMock);

            BookService bookService = new BookService(context.Object);

            // Act
            var bookResultSet = bookService.GetBooksByTitleOrAuthor(searchTerm);

            // Assert
            CollectionAssert.AreEquivalent(expectedResult, bookResultSet);
        }

        [Test]
        public void ReturnCorrectResults_WhenAuthorIsMatching()
        {
            // Arrange
            var context = new Mock<ILibrarySystemContext>();
            var books = GetBooks();
            string searchTerm = "Author";
            var expectedResult = books.Where(b => b.Author.Contains(searchTerm)).AsQueryable();
            var bookSetMock = QueryableDbSetMock.GetQueryableMockDbSet(books);
            context.Setup(c => c.Books).Returns(bookSetMock);

            BookService bookService = new BookService(context.Object);

            // Act
            var bookResultSet = bookService.GetBooksByTitleOrAuthor(searchTerm);

            // Assert
            CollectionAssert.AreEquivalent(expectedResult, bookResultSet);
        }

        private IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() { Id = Guid.NewGuid(), Title = "Title 1.1", Author = "Author 1" },
                new Book() { Id = Guid.NewGuid(), Title = "Title 1.2", Author = "Author 2" },
                new Book() { Id = Guid.NewGuid(), Title = "Title 2", Author = "Author 3" }
            };
        }
    }
}
