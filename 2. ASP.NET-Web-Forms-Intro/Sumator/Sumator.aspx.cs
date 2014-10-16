using System;

namespace Sumator
{
	public partial class Sumator : System.Web.UI.Page
	{
		protected void ButtonCalculateSum_Click(object sender, EventArgs e)
		{
			try
			{
				decimal firstNum = Decimal.Parse(this.TextBoxFirstNum.Text);
				decimal secondNum = Decimal.Parse(this.TextBoxSecondNum.Text);
				decimal sum = firstNum + secondNum;
				this.TextBoxSum.Text = sum.ToString();
			}
			catch (Exception)
			{
				this.TextBoxSum.Text = "Invalid.";
			}
		}
	}
}