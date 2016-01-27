namespace NewsSystem.Services.Contracts
{
    using NewsSystem.Models;
    using System.Linq;

    public interface ICategoriesServices
    {
        IQueryable<Category> GetAll();

        Category UpdateById(int id, string name);

        Category DeleteById(int id);

        Category Create(string name);
    }
}