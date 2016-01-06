using LikesDemo.Controls;
using LikesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace LikesDemo
{
    public partial class Posts : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<LikesDemo.Models.Post> ListViewPosts_GetData()
        {
            return this.dbContext.Posts;
        }

        protected int GetLikesValue(Post item)
        {
            int likesCount = item.Likes.Count(l => l.Value == true);
            int hatesCount = item.Likes.Count(l => l.Value == false);
            return likesCount - hatesCount;
        }

        protected bool? GetUserVote(Post item)
        {
            string userID = this.User.Identity.GetUserId();
            var like = item.Likes.FirstOrDefault(l => l.UserID == userID);
            if (like == null)
            {
                return null;
            }

            return like.Value;
        }

        protected void LikeControl_Like(object sender, LikeEventArgs e)
        {
            Post post = this.dbContext.Posts.Find(Convert.ToInt32(e.DataID));
            string userID = this.User.Identity.GetUserId();

            Like like = post.Likes.FirstOrDefault(l => l.UserID == userID);
            if (like == null)
            {
                like = new Like()
                {
                    UserID = userID,
                    PostID = Convert.ToInt32(e.DataID)
                };

                post.Likes.Add(like);
            }

            like.Value = e.LikeValue;
            this.dbContext.SaveChanges();

            //LikeControl ctrl = sender as LikeControl;
            DataBind();
        }
    }
}