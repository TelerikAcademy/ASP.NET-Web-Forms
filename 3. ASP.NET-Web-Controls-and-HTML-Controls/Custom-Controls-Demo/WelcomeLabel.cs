using System;
using System.Web;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Web.UI;
using System.Security.Permissions;

namespace Custom_Controls_Demo
{
    [
        AspNetHostingPermission(SecurityAction.Demand,
            Level = AspNetHostingPermissionLevel.Minimal),
        AspNetHostingPermission(SecurityAction.InheritanceDemand,
            Level = AspNetHostingPermissionLevel.Minimal),
        DefaultProperty("Text"),
        ToolboxData("<{0}:WelcomeLabel runat=\"server\"> </{0}:WelcomeLabel>")
    ]
    public class WelcomeLabel : WebControl
    {
        string result;

        [
            Bindable(true),
            Category("Appearance"),
            DefaultValue(""),
            Description("The welcome message text."),
            Localizable(true)
        ]
        public virtual string Text
        {
            get
            {
                string s = (string)ViewState["Text"];
                return (s == null) ? String.Empty : s;
            }
            set
            {
                ViewState["Text"] = value;
            }
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.WriteEncodedText(Text);
            if (Context != null)
            {
                string s = Context.User.Identity.Name;
                if (s != null && s != String.Empty)
                {
                    string[] split = s.Split('\\');
                    int n = split.Length - 1;
                    if (split[n] != String.Empty)
                    {
                        writer.Write(", ");
                        writer.Write(split[n]);
                    }
                }
            }
            writer.Write("!");
        }


        protected override void OnInit(EventArgs e)
        {
            result = string.Empty;
            result += "<strong>Init</strong> fired <br/>";
            base.OnInit(e);
        }

        protected override void LoadViewState(object savedState)
        {
            result += "<strong>LoadViewState</strong> fired <br/>";
            base.LoadViewState(savedState);
        }

        protected override void OnLoad(EventArgs e)
        {
            result += "<strong>Load</strong> fired <br/>";
            base.OnLoad(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            result += "<strong>PreRender</strong> fired <br/>";
            base.OnPreRender(e);
        }

        protected override object SaveViewState()
        {
            result += "<strong>SaveViewState</strong> fired <br/>";
            return base.SaveViewState();
        }

        protected override void Render(HtmlTextWriter writer)
        {

            result += "<strong>Render</strong> fired <br/>";
            //this.Page.Response.Write(result);
            base.Render(writer);
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}
