namespace NewsSystem.Services
{
    using Contracts;
    using System;
    using System.Linq;
    using Models;
    using Data.Repositories;

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

        public Article Create(Article newArticle)
        {
            this.articles.Add(newArticle);

            this.articles.SaveChanges();

            return newArticle;
        }

        public Article UpdateById(int id, Article updatedArticle)
        {
            var articleToUpdate = this.articles.GetById(id);

            articleToUpdate.CategoryId = updatedArticle.CategoryId;
            articleToUpdate.Content = updatedArticle.Content;
            articleToUpdate.Title = updatedArticle.Title;

            this.articles.SaveChanges();

            return updatedArticle;
        }

        public void DeleteById(int id)
        {
            this.articles.Delete(id);
            this.articles.SaveChanges();
        }
    }
}
