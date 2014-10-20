using System;
using System.IO;
using System.Data;

namespace ObjectDataSource
{
    public class FileSystemManager
    {
        public DataTable GetAllFiles(string folder)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folder);
            var files = dirInfo.GetFiles();

            // Return data table to allow automatic sorting + paging
            return files.ToDataTable();
        }
    }
}
