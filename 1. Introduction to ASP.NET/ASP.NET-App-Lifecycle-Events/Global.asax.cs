using System;
using System.Diagnostics;

namespace ASP.NET_App_Lifecycle_Events
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Trace.WriteLine("Application_Start Called.");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Trace.WriteLine("Session_Start Called.");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Trace.WriteLine("Application_BeginRequest Called.");
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            Trace.WriteLine("Application_AuthenticateRequest Called.");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Trace.WriteLine("Application_Error Called.");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Trace.WriteLine("Session_End Called.");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Trace.WriteLine("Application_End Called.");
        }
        protected void Application_EndRequest(object sender, EventArgs e)
        {
            Trace.WriteLine("Application_EndRequest Called.");
        }
    }
}