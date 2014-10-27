using LikeUserControl.Controls;
using LikeUserControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace LikeUserControl
{
    public partial class Posts : System.Web.UI.Page
    {
        public ForumDbContext dbContext { get; set; }

        public Posts()
        {
            this.dbContext = new ForumDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<LikeUserControl.Models.Post> ListViewPosts_GetData()
        {
            return this.dbContext.Posts.OrderBy(p => p.DateCreated);
        }

        protected void LikeControl_Like(object sender, LikeEventArgs e)
        {
            int postID = e.PostID;
            var post = this.dbContext.Posts.Find(postID);
            var existingLike = GetCurrentUsersLike(post);

            existingLike.Value = 1;
            post.Likes.Add(existingLike);

            this.dbContext.SaveChanges();

            var ctrl = sender as LikeControl;
            ctrl.LikesCount = post.Likes.Sum(l => l.Value);
            ctrl.UserVote = 1;
        }

        protected void LikeControl_DisLike(object sender, LikeEventArgs e)
        {
            int postID = e.PostID;
            var post = this.dbContext.Posts.Find(postID);
            var existingLike = GetCurrentUsersLike(post);

            existingLike.Value = -1;
            post.Likes.Add(existingLike);

            this.dbContext.SaveChanges();

            var ctrl = sender as LikeControl;
            ctrl.LikesCount = post.Likes.Sum(l => l.Value);
            ctrl.UserVote = -1;
        }

        private Like GetCurrentUsersLike(Post post)
        {
            string userID = this.User.Identity.GetUserId();

            var existingLike = post.Likes.FirstOrDefault(l => l.AuthorID == userID);
            if (existingLike == null)
            {
                existingLike = new Like()
                {
                    DateCreated = DateTime.Now,
                    AuthorID = userID
                };
            }
            return existingLike;
        }

        protected int CheckUserLike(int postID)
        {
            var userID = this.User.Identity.GetUserId();
            var userLike = this.dbContext.Likes.FirstOrDefault(l => l.AuthorID == userID && l.PostID == postID);

            if (userLike != null)
            {
                return userLike.Value;
            }
            else
            {
                return 0;
            }
        }
    }
}