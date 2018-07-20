using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTV.KTVCommon
{
    public class PathHelper
    {
        public static string GetRootDirectory()
        {
            string temp = Environment.CurrentDirectory;
            return temp;
        }

        public static string GetDownloadDir(Guid id)
        {
            string dir = GetRootDirectory() + "\\video\\"+ id.ToString();
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            return dir + "\\";
        }

        public static string GetScreenShotDir(string id)
        {
            string dir = GetRootDirectory() + "\\screenshot\\" + id;
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            return dir + "\\";
        }
    }
}
