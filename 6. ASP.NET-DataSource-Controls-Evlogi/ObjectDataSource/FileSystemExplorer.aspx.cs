using System;
//using System.Linq.Dynamic;
using System.IO;
using System.Web.UI.WebControls;

namespace ObjectDataSource
{
    public partial class FileSystemExplorer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SetRootFolderButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string folderPath = TextBoxFolderPath.Text;
                this.ObjectDataSourceFileSystem.
                    SelectParameters["folder"].DefaultValue = folderPath;
            }
        }

        protected void ValidatorFolder_ServerValidate(
            object source, ServerValidateEventArgs args)
        {
            string folderPath = TextBoxFolderPath.Text;
            args.IsValid = Directory.Exists(folderPath);
        }
    }
}
