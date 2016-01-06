using System;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void ButtonJustShowText_Click(object sender, EventArgs e)
    {
        string enteredText = TextBoxSampleText.Text;
        LabelEnteredText.Text = enteredText;
        LiteralEnteredText.Text = enteredText;
    }

    protected void ButtonShowHtmlEncoded_Click(object sender, EventArgs e)
    {
        string enteredText = TextBoxSampleText.Text;
        LabelEnteredText.Text = Server.HtmlEncode(enteredText);
        LiteralEnteredText.Text = Server.HtmlEncode(enteredText);
    }
}
