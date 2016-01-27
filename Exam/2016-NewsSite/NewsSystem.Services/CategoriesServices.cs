namespace NewsSystem.Services
{
    using NewsSystem.Services.Contracts;
    using System.Linq;
    using NewsSystem.Models;
    using Data.Repositories;

    public class CategoriesServices : ICategoriesServices
    {
        private IRepository<Category> categories;

        public CategoriesServices(IRepository<Category> categories)
        {
            this.categories = categories;
        }

        public IQueryable<Category> GetAll()
        {
            return this.categories.All();
        }

        public Category Create(string name)
        {
            var newCategory = new Category()
            {
                Name = name
            };

            this.categories.Add(newCategory);

            this.categories.SaveChanges();

            return newCategory;
        }

        public Category DeleteById(int id)
        {
            var categoryToDelete = this.categories.GetById(id);

            this.categories.Delete(categoryToDelete);

            this.categories.SaveChanges();

            return categoryToDelete;
        }

        public Category UpdateById(int id, string name)
        {
            var categoryToUpdate = this.categories.GetById(id);

            categoryToUpdate.Name = name;

            this.categories.SaveChanges();

            return categoryToUpdate;
        }
    }
}
