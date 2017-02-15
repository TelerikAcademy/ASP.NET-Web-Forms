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

        public IQueryable<Category> GetAllCategories()
        {
            return this.librarySystemContext.Categories.Include(c => c.Books);
        }
    }
}