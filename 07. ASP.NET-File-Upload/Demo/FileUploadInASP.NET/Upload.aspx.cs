using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadInASP.NET
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Expires = -1;
            try
            {
                HttpPostedFile file = Request.Files["uploaded"];

                string savepath = Server.MapPath("~/Uploaded_Files/");
                string filename = file.FileName;
                file.SaveAs(savepath + filename);
                Response.ContentType = "application/json";
                Response.Write("{}");
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}