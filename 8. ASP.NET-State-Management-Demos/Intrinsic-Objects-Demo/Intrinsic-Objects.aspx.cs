using System;
using System.Collections;

namespace Intrinsic_Objects_Demo
{
	public partial class Intrinsic_Objects : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			LiteralOutput.Text += "Request URI: " + Request.Url.AbsoluteUri + "<br/>";
			LiteralOutput.Text += "Server.MapPath(): " + Server.MapPath("~/Web.config") + "<br/>";
			string textToEncode = "Did you try ASP.NET 4.5?";
			LiteralOutput.Text += "UrlEncode(\"" + textToEncode + "\") --> " + 
				Server.UrlEncode(textToEncode) + "<br/>";
			LiteralOutput.Text += "Browser Type: " + Request.Browser.Type + "<br/>";

			foreach (DictionaryEntry capability in Request.Browser.Capabilities)
			{
				LiteralOutput.Text += "Browser capability: " +
					capability.Key + " -> " + capability.Value + "<br/>";
			}
            var cookies = Request.Cookies;

			var serverVars = Request.ServerVariables;
			for (int i = 0; i < serverVars.Count; i++)
			{
				LiteralOutput.Text += "ServerVariables[" +
					serverVars.Keys[i] + "] -> " +
					serverVars[i] + "<br/>";
			}
		}
	}
}
