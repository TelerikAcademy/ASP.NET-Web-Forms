namespace List_Controls
{
    using System;

    public partial class ListControlsDemo : System.Web.UI.Page
    {
        protected void ListBoxTowns_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowResults();
        }

        protected void DropDownListTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowResults();
        }

        private void ShowResults()
        {
            this.LiteralResult.Text =
                "Town: " + this.ListBoxTowns.SelectedValue +
                "; Transportation: " + this.DropDownListTransport.SelectedValue;
        }
    }
}