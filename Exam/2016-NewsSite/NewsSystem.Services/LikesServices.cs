namespace NewsSystem.Services
{
    using Contracts;
    using System.Linq;
    using Models;
    using Data.Repositories;

    public class LikesServices : ILikesServices
    {
        private IRepository<Like> likes;

        public LikesServices(IRepository<Like> likes)
        {
            this.likes = likes;
        }

        public Like Create(Like like)
        {
            this.likes.Add(like);
            this.likes.SaveChanges();

            return like;
        }

        public Like GetByAuthorAndArticle(string authorId, int articleId)
        {
            return this.likes.All().FirstOrDefault(x => x.AuthorId == authorId && x.ArticleId == articleId);
        }
    }
}
