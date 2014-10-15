using System;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PanelDemo: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Show / hide the panel

        if (CheckBox.Checked)
        {
            this.PanelExample.Visible = false;
        }
        else
        {
            this.PanelExample.Visible = true;
        }

        // Generate label controls

        int numlabels = int.Parse(DropDownLabels.SelectedItem.Value);

        for (int i = 1; i <= numlabels; i++)
        {
            Label label = new Label();
            label.Text = "Label" + i.ToString();
            label.ID = "Label" + i.ToString();
            this.PanelExample.Controls.Add(label);
            this.PanelExample.Controls.Add(new LiteralControl("<br>"));
        }

        // Generate textbox controls

        int numtexts = int.Parse(DropDownTextBoxes.SelectedItem.Value);

        for (int i = 1; i <= numtexts; i++)
        {
            TextBox textBox = new TextBox();
            textBox.Text = "TextBox" + i.ToString();
            textBox.ID = "TextBox" + i.ToString();
            this.PanelExample.Controls.Add(textBox);
            this.PanelExample.Controls.Add(new LiteralControl("<br>"));
        }

        // Generate button
        Button buttonSubmit = new Button();
        buttonSubmit.ID = "submitButton";
        buttonSubmit.Text = "Submit";
        buttonSubmit.Click += ButtonSubmit_Click;
        this.PanelExample.Controls.Add(buttonSubmit);
        this.PanelExample.DefaultButton = buttonSubmit.ID;
    }

    private void ButtonSubmit_Click(object sender, EventArgs e)
    {
        StringBuilder textBoxesText = new StringBuilder();
        foreach (var control in this.PanelExample.Controls)
	    {
            if (control is TextBox)
            {
                TextBox textBox = (TextBox)control;
                textBoxesText.Append(textBox.Text);
            }
	    }

        string textToShow = "Result: " + textBoxesText.ToString();
        this.PanelExample.Controls.Add(
            new LiteralControl("<br>"));
        this.PanelExample.Controls.Add(
            new LiteralControl(textToShow));
    }
}
