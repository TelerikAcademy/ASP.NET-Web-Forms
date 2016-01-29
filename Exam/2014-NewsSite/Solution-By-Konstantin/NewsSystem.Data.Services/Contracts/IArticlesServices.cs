namespace NewsSystem.Data.Services.Contracts
{
    using NewsSystem.Data.Models;
    using System.Linq;

    public interface IArticlesServices
    {
        IQueryable<Article> GetTop(int count);

        IQueryable<Article> GetAll();

        Article GetById(int id);

        void UpdateById(int id, Article updateArticle);

        void DeleteById(int id);

        void Create(Article article);
    }
}
