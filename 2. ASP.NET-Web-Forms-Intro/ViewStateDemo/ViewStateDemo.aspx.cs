using System;
using System.Drawing;

namespace ViewStateDemo
{
	public partial class ViewStateDemo : System.Web.UI.Page
	{
        Random rnd = new Random();

        protected void ButtonChangePanelColor_Click(object sender, EventArgs e)
        {
            this.Panel.BackColor = Color.FromArgb(rnd.Next(0, 0xFFFFFF));
            this.Panel.ForeColor = Color.FromArgb(rnd.Next(0, 0xFFFFFF));
        }
        protected void ButtonChangeTextBoxWidth_Click(object sender, EventArgs e)
        {
            this.TextBoxExample.Width = rnd.Next(10, 300);
        }
    }
}