using NewsSite.Controls;
using NewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace NewsSite
{
    public partial class ViewArticle : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public NewsSite.Models.Article FormViewArticle_GetItem([QueryString("id")]int? id)
        {
            return this.dbContext.Articles.FirstOrDefault(a => a.ID == id); ;
        }

        protected int GetLikes(Article item)
        {
            if (item.Likes.Count > 0)
            {
                return item.Likes.Sum(l => l.Value);
            }

            return 0;
        }

        protected void LikeControl_Like(object sender, LikeEventArgs e)
        {
            string userID = this.User.Identity.GetUserId();
            Article article = this.dbContext.Articles.Find(e.DataID);
            Like like = article.Likes.FirstOrDefault(l => l.UserID == userID);
            if (like == null)
            {
                like = new Like()
                {
                    UserID = userID,
                };

                this.dbContext.Articles.Find(e.DataID).Likes.Add(like);
            }

            like.Value = e.LikeValue;
            this.dbContext.SaveChanges();

            var control = sender as LikeControl;
            control.Value = article.Likes.Sum(l => l.Value);
            control.CurrentUserVote = e.LikeValue;
        }

        protected int GetCurrentUserVote(Article item)
        {
            string userID = User.Identity.GetUserId();
            Like like = item.Likes.FirstOrDefault(l => l.UserID == userID);
            if (like == null)
            {
                return 0;
            }

            return like.Value;
        }
    }
}