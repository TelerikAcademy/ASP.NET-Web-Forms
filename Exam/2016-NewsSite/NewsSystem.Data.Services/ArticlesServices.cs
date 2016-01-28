namespace NewsSystem.Data.Services
{
    using Contracts;
    using System.Linq;
    using NewsSystem.Data.Models;
    using NewsSystem.Data.Repositories;

    public class ArticlesServices : IArticlesServices
    {
        private IRepository<Article> articles;

        public ArticlesServices(IRepository<Article> articles)
        {
            this.articles = articles;
        }

        public IQueryable<Article> GetAll()
        {
            return this.articles.All();
        }

        public IQueryable<Article> GetTop(int count)
        {
            return this.articles.All().OrderByDescending(x => x.Likes.Count()).Take(count);
        }

        public Article GetById(int id)
        {
            return this.articles.GetById(id);
        }

        public void Create(Article article)
        {
            this.articles.Add(article);
            this.articles.SaveChanges();
        }

        public void UpdateById(int id, Article updateArticle)
        {
            var articleToUpdate = this.articles.GetById(id);

            articleToUpdate.CategoryId = updateArticle.CategoryId;
            articleToUpdate.Title = updateArticle.Title;
            articleToUpdate.Content = updateArticle.Content;

            this.articles.SaveChanges();
        }

        public void DeleteById(int id)
        {
            this.articles.Delete(id);
            this.articles.SaveChanges();
        }
    }
}
