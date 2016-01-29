namespace NewsSystem.Web.Controls
{
    using Data.Models;
    using Data.Services.Contracts;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Web.UI;
    using Data.Services;
    using Data;
    using Data.Repositories;

    public partial class LikeHateControl : System.Web.UI.UserControl
    {
        //[Inject]
        //public ILikesServices LikesServices { get; set; }

        public ILikesServices LikesServices { get; set; } =
            new LikesServices(new GenericRepository<Like>(new NewsSystemDbContext()));

        protected void Page_Load(object sender, EventArgs e)
        {
            var userId = Page.User.Identity.GetUserId();
            var articledId = int.Parse(this.Request.QueryString["id"]);
            var like = this.LikesServices.GetByAuthorIdAndArticledId(userId, articledId);

            if(like == null)
            {
                return;
            }

            (like.Value ? this.btnLike : this.btnHate).Visible = false;
        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
            this.HandleLikeEvent(true);
        }

        protected void btnHate_Click(object sender, EventArgs e)
        {
            this.HandleLikeEvent(false);
        }

        private void HandleLikeEvent(bool isLike)
        {
            var userId = Page.User.Identity.GetUserId();
            var articledId = int.Parse(this.Request.QueryString["id"]);
            var like = this.LikesServices.GetByAuthorIdAndArticledId(userId, articledId);

            if (like != null)
            {
                this.LikesServices.ChangeLike(userId, articledId);
                (like.Value ? this.btnLike : this.btnHate).Visible = false;
                (!like.Value ? this.btnLike : this.btnHate).Visible = true;
            }
            else
            { 
                var createdLike = new Like()
                {
                    AuthorId = Page.User.Identity.GetUserId(),
                    ArticleId = int.Parse(this.Request.QueryString["id"]),
                    Value = isLike
                };
                this.LikesServices.CreateLike(createdLike);

                (createdLike.Value ? this.btnLike : this.btnHate).Visible = false;
                (!createdLike.Value ? this.btnLike : this.btnHate).Visible = true;
            }

        }
    }
}