using System;
using System.Web;

public class SampleHttpModule : IHttpModule
{
    public void Init(HttpApplication application)
    {
        application.BeginRequest += this.Application_BeginRequest;
        application.EndRequest += this.Application_EndRequest;
    }

    private void Application_BeginRequest(object source, EventArgs e)
    {
        HttpApplication application = (HttpApplication)source;
        HttpContext context = application.Context;
        string filePath = context.Request.FilePath;
        string fileExtension =
            VirtualPathUtility.GetExtension(filePath);
        if (fileExtension.Equals(".aspx"))
        {
            context.Response.Write("<hr>SampleHttpModule: Beginning of Request<hr>");
        }
    }

    private void Application_EndRequest(object source, EventArgs e)
    {
        HttpApplication application = (HttpApplication)source;
        HttpContext context = application.Context;
        string filePath = context.Request.FilePath;
        string fileExtension = VirtualPathUtility.GetExtension(filePath);
        if (fileExtension.Equals(".aspx"))
        {
            context.Response.Write("<hr>SampleHttpModule: End of Request<hr>");
        }
    }

    public void Dispose()
    {
    }
}
