using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadInASP.NET
{
    public partial class SaveFileToStreamUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            byte[] fileData = null;
            Stream fileStream = null;
            int length = 0;

            if (FileUploadControl.HasFile)
            {
                length = FileUploadControl.PostedFile.ContentLength;
                fileData = new byte[length + 1];
                fileStream = FileUploadControl.PostedFile.InputStream;
                fileStream.Read(fileData, 0, length);

                File.Text = string.Join(" ", fileData);
            }
        }
    }
}