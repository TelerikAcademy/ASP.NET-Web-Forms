namespace NewsSystem.Data.Services
{
    using Contracts;
    using System.Linq;
    using Models;
    using Repositories;

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

        public Category GetById(int id)
        {
            return this.categories.GetById(id);
        }

        public Category Create(string name)
        {
            var category = new Category() { Name = name };

            this.categories.Add(category);

            this.categories.SaveChanges();

            return category;
        }

        public void UpdateNameById(int id, string name)
        {
            this.categories.GetById(id).Name = name;

            this.categories.SaveChanges();
        }

        public void DeleteId(int id)
        {
            this.categories.Delete(id);
            this.categories.SaveChanges();
        }
    }
}
