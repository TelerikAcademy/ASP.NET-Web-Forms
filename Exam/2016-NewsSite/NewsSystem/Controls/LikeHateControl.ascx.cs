namespace NewsSystem.Controls
{
    using Services.Contracts;
    using Ninject;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Microsoft.AspNet.Identity;
    using NewsSystem.Services;
    using Models;
    using Data.Repositories;
    using Data;

    public partial class LikeHateControl : System.Web.UI.UserControl
    {
        public ILikesServices LikesServices { get; set; } = new LikesServices(new GenericRepository<Like>(new NewsSystemDbContext()));

        protected void Page_Load(object sender, EventArgs e)
        {
            var articleIdAsString = this.Request.QueryString["id"];

            // TODO: validaiton

            var userId = Page.User.Identity.GetUserId();

            var likeSoFar = this.LikesServices.GetByAuthorAndArticle(userId, int.Parse(articleIdAsString));

            if (likeSoFar == null)
            {
                return;
            }

            if (likeSoFar.Value)
            {
                this.btnLike.Visible = false;
            }
            else
            {
                this.btnHate.Visible = false;
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            
        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
            var articleIdAsString = this.Request.QueryString["id"];

            // TODO: validation

            var newLike = new Like()
            {
                Value = true,
                ArticleId = int.Parse(articleIdAsString),
                AuthorId = Page.User.Identity.GetUserId()
            };

            this.LikesServices.Create(newLike);
        }

        protected void btnHate_Click(object sender, EventArgs e)
        {
            var articleIdAsString = this.Request.QueryString["id"];

            // TODO: validation

            var newLike = new Like()
            {
                Value = false,
                ArticleId = int.Parse(articleIdAsString),
                AuthorId = Page.User.Identity.GetUserId()
            };

            this.LikesServices.Create(newLike);
        }
    }
}