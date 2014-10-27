using LikeUserControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LikeUserControl.Controls
{
    public class LikeEventArgs : EventArgs
    {
        public int PostID { get; set; }

        public LikeEventArgs(int postID)
        {
            this.PostID = postID;
        }
    }

    public partial class LikeControl : System.Web.UI.UserControl
    {
        public int DataID
        {
            get
            {
                return (int)ViewState["DataID"];
            }
            set
            {
                ViewState["DataID"] = value;
            }
        }

        public int LikesCount
        {
            get
            {
                return (int)ViewState["LikesCount"];
            }
            set
            {
                ViewState["LikesCount"] = value;
            }
        }

        public int UserVote
        {
            get
            {
                object userVote = ViewState["UserVote"];
                if (userVote == null)
                {
                    return 0;
                }
                return (int) userVote;
            }
            set
            {
                ViewState["UserVote"] = value;
            }
        }

        public delegate void LikeEvent(object sender, LikeEventArgs e);

        public event LikeEvent Like;

        public event LikeEvent DisLike;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated == false)
            {
                this.likeWrapper.Visible = false;
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.LabelLikes.Text = this.LikesCount.ToString();

            if (this.UserVote > 0)
            {
                this.ButtonLike.Visible = false;
                this.ButtonDislike.Visible = true;
            }
            else if (this.UserVote < 0)
            {
                this.ButtonLike.Visible = true;
                this.ButtonDislike.Visible = false;
            }
        }

        protected void ButtonLike_Click(object sender, EventArgs e)
        {
            this.Like(this, new LikeEventArgs(this.DataID));
        }

        protected void ButtonDislike_Click(object sender, EventArgs e)
        {
            this.DisLike(this, new LikeEventArgs(this.DataID));
        }
    }
}