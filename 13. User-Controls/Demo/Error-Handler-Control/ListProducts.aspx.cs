using System;

namespace Error_Handler_Control
{
	public partial class ListProducts : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ButtonRefresh_Click(object sender, EventArgs e)
		{
			ErrorSuccessNotifier.AddInfoMessage("Products loaded.");
		}
	}
}
