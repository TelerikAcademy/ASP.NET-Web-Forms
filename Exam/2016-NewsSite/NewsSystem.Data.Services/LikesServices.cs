namespace NewsSystem.Data.Services
{
    using Contracts;
    using System.Linq;
    using Models;
    using Repositories;
    using System;

    public class LikesServices : ILikesServices
    {
        private IRepository<Like> likes;

        public LikesServices(IRepository<Like> likes)
        {
            this.likes = likes;
        }

        public void ChangeLike(string userId, int articleId)
        {
            var like = this.GetByAuthorIdAndArticledId(userId, articleId);

            like.Value = !like.Value;

            this.likes.SaveChanges();
        }

        public void CreateLike(Like like)
        {
            this.likes.Add(like);
            this.likes.SaveChanges();
        }

        public Like GetByAuthorIdAndArticledId(string userId, int articleId)
        {
            return this.likes.All().FirstOrDefault(x => x.AuthorId == userId && x.ArticleId == articleId);
        }
    }
}
