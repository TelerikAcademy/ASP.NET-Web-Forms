using System;
using System.Data.Entity;
using System.Linq;
using LibrarySystemLiveDemo.Data;
using LibrarySystemLiveDemo.Data.Models;

namespace LibrarySystemLiveDemo.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ILibrarySystemContext librarySystemContext;
        
        public CategoryService(ILibrarySystemContext librarySystemContext)
        {
            this.librarySystemContext = librarySystemContext;
        }

        public IQueryable<Category> GetAllCategoriesSortedById()
        {
            return this.librarySystemContext.Categories.OrderBy(c => c.Id);
        }

        public IQueryable<Category> GetAllCategoriesWithBooksIncluded()
        {
            return this.librarySystemContext.Categories.Include(c => c.Books);
        }

        public int InsertCategory(Category category)
        {
            this.librarySystemContext.Categories.Add(category);
            return this.librarySystemContext.SaveChanges();
        }
    }
}