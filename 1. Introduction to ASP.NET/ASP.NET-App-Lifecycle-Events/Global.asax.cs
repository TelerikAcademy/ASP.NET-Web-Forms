using System;
using System.Diagnostics;
using System.IO;

namespace ASP.NET_App_Lifecycle_Events
{
    public class Global : System.Web.HttpApplication
    {
        private static string LogFilePath = Path.GetTempFileName();

        protected void Application_Start(object sender, EventArgs e)
        {
            Log("Application_Start Called.");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Log("Session_Start Called.");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Response.Write(string.Format("Log file: {0}", LogFilePath));
            Log("Application_BeginRequest Called.");
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            Log("Application_AuthenticateRequest Called.");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Log("Application_Error Called.");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Log("Session_End Called.");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Log("Application_End Called.");
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            Log("Application_EndRequest Called.");
        }

        private void Log(string line)
        {
            if (!File.Exists(LogFilePath))
            {
                File.Create(LogFilePath);
            }

            var debugLine = string.Format("[{0}] {1}", DateTime.Now, line);

            File.AppendAllLines(LogFilePath, new[] { debugLine });
            Trace.WriteLine(debugLine);
        }
    }
}