using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MyKTV.KTVEnum;

namespace MyKTV.KTVModel
{
    public class DownloadInfo
    {

        public string WebUrl { get; set; }

        public string SavePath { get; set; }

        public bool IsDownloading { get; set; } = false;

        public bool IsCompelet { get; set; } = false;

        public int Sort { get; set; }

        public MTVInfo MTV { get; set; }

        public MTVDownloadType DownloadType { get; set; }

        public DownloadProgressChangedEventHandler ProcessChange { get; set; }

        public AsyncCompletedEventHandler Complete { get; set; }
    }
}
