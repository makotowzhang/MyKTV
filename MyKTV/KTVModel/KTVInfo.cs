using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTV.KTVModel
{
    public class MTVInfo
    {
        public Guid Id { get; set; }
        public string MTVName { get; set; }

        public string Artist { get; set; }

        public string MTVImage { get; set; }

        public string LocalImagePath { get; set; }

        public string DetailUrl { get; set; }

        public string CloudDiskUrl { get; set; }

        public string ServerUrl { get; set; }

        public string ED2KUrl { get; set; }

        public string SouceFileName { get; set; }

        public string FileName { get; set; }

        public string SavePath { get; set; }

        public string MTVSize { get; set; }

    }
}
