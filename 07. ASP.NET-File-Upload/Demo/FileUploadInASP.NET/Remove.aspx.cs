using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadInASP.NET
{
    public partial class Remove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var file = Request.Form["fileNames"];

            if (file != null)
            {
                var fileName = Path.GetFileName(file);
                var physicalPath = Path.Combine(Server.MapPath("~/Uploaded_Files"), fileName);

                // TODO: Verify user permissions

                if (System.IO.File.Exists(physicalPath))
                {
                    File.Delete(physicalPath);
                }
            }
        }
    }
}