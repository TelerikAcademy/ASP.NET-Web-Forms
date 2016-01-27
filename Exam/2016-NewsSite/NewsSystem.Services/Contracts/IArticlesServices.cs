namespace NewsSystem.Services.Contracts
{
    using Models;
    using System.Linq;

    public interface IArticlesServices
    {
        IQueryable<Article> GetTop(int count);

        IQueryable<Article> GetAll();

        Article UpdateById(int id, Article updatedArticle);

        void DeleteById(int id);

        Article GetById(int id);

        Article Create(Article newArticle);
    }
}
