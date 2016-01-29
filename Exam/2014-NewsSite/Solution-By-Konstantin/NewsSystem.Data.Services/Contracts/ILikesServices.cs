namespace NewsSystem.Data.Services.Contracts
{
    using Models;

    public interface ILikesServices
    {
        Like GetByAuthorIdAndArticledId(string userId, int articleId);

        void ChangeLike(string userId, int articleId);

        void CreateLike(Like like);
    }
}
