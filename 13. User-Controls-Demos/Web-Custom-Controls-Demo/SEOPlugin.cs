using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Custom_Controls_Demo
{
	[DefaultProperty("Text")]
	[ToolboxData("<{0}:SEO_Plugin runat=server></{0}:SEO_Plugin>")]
	public class SEOPlugin : WebControl
	{
		[Category("Behavior")]
		[Description("The specified suffix is added to the page's title.")]
		public string TitleSuffix { get; set; }

		[Category("Behavior")]
		[Description("The specified text added as meta description in the page header.")]
		public string MetaDescription { get; set; }

		[Category("Behavior")]
		[Description("The specified list of comma-separated keywords are added as meta keywords in the page header.")]
		public string MetaKeywords { get; set; }

		protected override void RenderContents(HtmlTextWriter output)
		{
			output.Write("<!-- SEO Plugin v.0.1 -->");
		}

		protected override void OnPreRender(EventArgs e)
		{
			// Append the title suffix after the page title
			this.Page.Title += TitleSuffix;

			// Add meta keywords tag
			Literal literalMetaKeywords = new Literal();
			literalMetaKeywords.Text = string.Format(
				"<meta name='keywords' content='{0}' />\n", MetaKeywords);
			this.Page.Header.Controls.Add(literalMetaKeywords);

			// Add meta description tag
			Literal literalMetaDescription = new Literal();
			literalMetaDescription.Text = string.Format(
				"<meta name='description' content='{0}' />\n", MetaDescription);
			this.Page.Header.Controls.Add(literalMetaDescription);
		}
	}
}
