namespace NewsSystem.Data.Services.Contracts
{
    using Models;
    using System.Linq;

    public interface ICategoriesServices
    {
        IQueryable<Category> GetAll();

        Category Create(string name);

        void UpdateNameById(int id, string name);

        void DeleteId(int id);
    }
}
