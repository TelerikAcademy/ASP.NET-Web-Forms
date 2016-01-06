using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSite.Controls
{
    public class LikeEventArgs : EventArgs
    {
        public LikeEventArgs(int dataID, int likeValue)
        {
            this.DataID = dataID;
            this.LikeValue = likeValue;
        }

        public int DataID { get; set; }
        public int LikeValue { get; set; }
    }

    public partial class LikeControl : System.Web.UI.UserControl
    {
        public int Value { get; set; }

        public int DataID { get; set; }

        public int CurrentUserVote { get; set; }

        public delegate void LikeEventHandler(object sender, LikeEventArgs e);

        public event LikeEventHandler Like;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                this.ControlWrapper.Visible = false;
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.LabelValue.Text = this.Value.ToString();

            if (this.CurrentUserVote > 0)
            {
                this.ButtonLike.Visible = false;
                this.ButtonDislike.Visible = true;
            }
            else if (this.CurrentUserVote < 0)
            {
                this.ButtonLike.Visible = true;
                this.ButtonDislike.Visible = false;
            }
        }

        protected void ButtonLike_Command(object sender, CommandEventArgs e)
        {
            int likeValue = e.CommandName == "Like" ? 1 : -1;
            this.Like(this, new LikeEventArgs(Convert.ToInt32(e.CommandArgument), likeValue));
        }
    }
}