namespace Sumator
{
    using System;
    using System.Globalization;

    public partial class Sumator : System.Web.UI.Page
    {
        protected void ButtonCalculateSum_Click(object sender, EventArgs e)
        {
            try
            {
                var firstNum = decimal.Parse(this.TextBoxFirstNum.Text);
                var secondNum = decimal.Parse(this.TextBoxSecondNum.Text);
                var sum = firstNum + secondNum;
                this.TextBoxSum.Text = sum.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                this.TextBoxSum.Text = "Invalid.";
            }
        }
    }
}
