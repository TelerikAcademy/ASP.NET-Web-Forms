using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using LibrarySystemLiveDemo.Services;
using LibrarySystemLiveDemo.MVP.Books;
using LibrarySystemLiveDemo.Data.Models;

namespace LibrarySystemLiveDemo.MVP.Tests.Books.BooksPresenterTests
{
    [TestFixture]
    public class View_OnCategoriesGetData_Should
    {
        [Test]
        public void AddCategoriesToViewModel_WhenOnCategoriesGetDataEventIsRaised()
        {
            // Arrange
            var viewMock = new Mock<IBooksView>();
            viewMock.Setup(v => v.Model).Returns(new BooksViewModel());

            var categories = GetCategoriesWithBooks();
            var categoryServiceMock = new Mock<ICategoryService>();
            categoryServiceMock.Setup(c => c.GetAllCategoriesWithBooksIncluded())
                .Returns(categories);

            BooksPresenter booksPresenter = new BooksPresenter(viewMock.Object, categoryServiceMock.Object);

            // Act
            viewMock.Raise(v => v.OnCategoriesGetData += null, EventArgs.Empty);

            // Assert
            CollectionAssert.AreEquivalent(categories, viewMock.Object.Model.Categories);
        }

        private IQueryable<Category> GetCategoriesWithBooks()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Category 1",
                    Books = new List<Book>() { new Book() { Id = Guid.NewGuid() } }
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Category 2"
                }
            }.AsQueryable();
        }
    }
}
