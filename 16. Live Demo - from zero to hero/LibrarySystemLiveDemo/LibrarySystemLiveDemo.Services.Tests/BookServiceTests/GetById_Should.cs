using System;
using System.Data.Entity;
using LibrarySystemLiveDemo.Data;
using LibrarySystemLiveDemo.Data.Models;
using Moq;
using NUnit.Framework;

namespace LibrarySystemLiveDemo.Services.Tests.BookServiceTests
{
    [TestFixture]
    public class GetById_Should
    {
        [Test]
        public void ReturnNull_WhenIdParameterIsNull()
        {
            // Arrange
            var contextMock = new Mock<ILibrarySystemContext>();
            BookService bookService = new BookService(contextMock.Object);

            // Act
            Book bookResult = bookService.GetById(null);

            // Assert
            Assert.IsNull(bookResult);
        }

        [Test]
        public void ReturnBook_WhenIdIsValid()
        {
            // Arrange
            var contextMock = new Mock<ILibrarySystemContext>();
            var bookSetMock = new Mock<IDbSet<Book>>();
            contextMock.Setup(c => c.Books).Returns(bookSetMock.Object);
            Guid bookId = Guid.NewGuid();
            Book book = new Book() { Id = bookId, Title = "Title 1" };

            bookSetMock.Setup(b => b.Find(bookId)).Returns(book);

            BookService bookService = new BookService(contextMock.Object);

            // Act
            Book bookResult = bookService.GetById(bookId);

            // Assert
            Assert.AreSame(book, bookResult);
        }
    }
}