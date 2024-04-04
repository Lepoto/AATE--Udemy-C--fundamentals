using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File, FileInfo 

            var path = @"c:\temp\somefile.jpg";
            
            File.Copy(@"c:\temp\myfile.jpg",@"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if(File.Exists(path))
            {
                // it returns boolean
            }

            var content = File.ReadAllText(path); // it returns a string

            var fileinfo = new FileInfo(path);
            fileinfo.Delete();
            fileinfo.CopyTo("...");

            if(fileinfo.Exists)
            {
                //
            }

            // Directory, DirectoryInfo
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\temp\projects", "*.*", SearchOption.AllDirectories);
        }
    }
}
