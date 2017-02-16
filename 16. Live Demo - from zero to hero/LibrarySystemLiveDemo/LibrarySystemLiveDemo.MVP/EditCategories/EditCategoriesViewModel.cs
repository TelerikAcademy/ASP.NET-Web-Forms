using System.Linq;
using LibrarySystemLiveDemo.Data.Models;

namespace LibrarySystemLiveDemo.MVP.EditCategories
{
    public class EditCategoriesViewModel
    {
        public IQueryable<Category> Categories { get; set; }
    }
}