using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace ObjectDS
{
    public class FileSystemManager
    {
        public DataTable GetAllFiles(string path)
        {
            DirectoryInfo folder = new DirectoryInfo(path);
            FileInfo[] files = folder.GetFiles();

            return files.ToDataTable();
        }
    }
}