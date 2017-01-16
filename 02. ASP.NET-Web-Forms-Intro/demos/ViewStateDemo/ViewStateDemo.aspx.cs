namespace ViewStateDemo
{
    using System;
    using System.Drawing;

    public partial class ViewStateDemo : System.Web.UI.Page
    {
        private Random rnd = new Random();

        protected void ButtonChangePanelColor_Click(object sender, EventArgs e)
        {
            this.Panel.BackColor = Color.FromArgb(this.rnd.Next(0, 0xFFFFFF));
            this.Panel.ForeColor = Color.FromArgb(this.rnd.Next(0, 0xFFFFFF));
        }

        protected void ButtonChangeTextBoxWidth_Click(object sender, EventArgs e)
        {
            this.TextBoxExample.Width = this.rnd.Next(10, 300);
        }
    }
}
