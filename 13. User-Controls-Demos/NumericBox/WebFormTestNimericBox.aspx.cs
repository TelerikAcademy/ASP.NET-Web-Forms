using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlsExample
{
    public partial class WebFormTestNimericBox : System.Web.UI.Page
    {
        protected void NumberixBoxAge_ValueChanged(
            object sender, EventArgs e)
        {
            this.LabelInfo.Visible = true;
            this.LabelInfo.Text = "changed";
        }
    }
}