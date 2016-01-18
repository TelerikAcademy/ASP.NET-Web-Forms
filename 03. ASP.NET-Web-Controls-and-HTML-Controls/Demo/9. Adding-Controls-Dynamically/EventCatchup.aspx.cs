namespace _9.Control_Lifecycle_Catchup
{
    using System;
    using System.Web.UI.WebControls;

    public partial class AddingDynamicControls : System.Web.UI.Page
    {
        protected void BtnClick(object sender, EventArgs e)
        {
            this.eventLog.Items.Add(new ListItem("Button Click called"));
        }

        protected void BtnInit(object sender, EventArgs e)
        {
            this.eventLog.Items.Add(new ListItem("Button Init called"));
        }

        protected void BtnLoad(object sender, EventArgs e)
        {
            this.eventLog.Items.Add(new ListItem("Button Load called"));
        }

        protected void BtnPreRender(object sender, EventArgs e)
        {
            this.eventLog.Items.Add(new ListItem("Button PreRender called"));
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            this.eventLog.Items.Add(new ListItem("Page Init event called"));
            
            // this.AddButtonToForm();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.eventLog.Items.Add(new ListItem("Page Load event called"));

            this.AddButtonToForm();
        }

        private void AddButtonToForm()
        {
            var button = new Button();
            button.Text = "Click me!";

            button.Init += this.BtnInit;
            button.Load += this.BtnLoad;
            button.PreRender += this.BtnPreRender;
            button.Click += this.BtnClick;

            this.form1.Controls.Add(button);
        }
    }
}