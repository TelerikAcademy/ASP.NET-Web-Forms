namespace NewsSystem.Services.Contracts
{
    using Models;
    public interface ILikesServices
    {
        Like GetByAuthorAndArticle(string authorId, int articleId);

        Like Create(Like like);
    }
}
