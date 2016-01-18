namespace _9.Adding_Controls_Dynamically
{
    using System;
    using System.Web.UI.WebControls;

    public partial class ReduceViewstateSize : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var lbl = new Label();
            this.Form.Controls.Add(lbl);
            lbl.Text = "Pesho, Gosho i Tosho hodili na krychma";
        }
    }
}