using System.Linq;
using LibrarySystemLiveDemo.Data.Models;

namespace LibrarySystemLiveDemo.Services
{
    public interface ICategoryService
    {
        IQueryable<Category> GetAllCategoriesWithBooksIncluded();

        IQueryable<Category> GetAllCategoriesSortedById();

        int InsertCategory(Category category);
    }
}