using System;

namespace Error_Handler_Control
{
	public partial class AddProduct : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ButtonAddSuccess_Click(object sender, EventArgs e)
		{
			ErrorSuccessNotifier.AddSuccessMessage("Product added.");
            ErrorSuccessNotifier.ShowAfterRedirect = true;
            Response.Redirect("ListProducts.aspx");
		}

		protected void ButtonAddError_Click(object sender, EventArgs e)
		{
			ErrorSuccessNotifier.AddWarningMessage("Warning: product description cannot be empty.");
			ErrorSuccessNotifier.AddErrorMessage("Cannot add product. Make sure the product name is valid.");
		}
	}
}
