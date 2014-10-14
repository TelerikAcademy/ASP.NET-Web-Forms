using System;
using System.Web;

public class TelerikAcademyHttpHandler : IHttpHandler
{
    /// <summary>
    /// This handler is called whenever a file ending in .nakov is
    /// requested. A file with that extension does not need to exist
    /// </summary>
    public void ProcessRequest(HttpContext context)
    {
        HttpResponse response = context.Response;
        response.ContentType = "text/plain";
        response.Write("I am Telerik Academy's HTTP handler.\r\n");
        response.Write("Response date: " + DateTime.Now);
    }

    public bool IsReusable
    {
        // Return true to keep the handler in memory (pooling).
        get { return false; }
    }
}
