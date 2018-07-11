using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTV.KTVModel;

namespace MyKTV.KTVStatus
{
    public static class RunTimeData
    {
        public static List<Sprite2D> VideoSprite { get; set; } = new List<Sprite2D>();

        public static List<KTVQueue> VideoQueue { get; set; } = new List<KTVQueue>();

        public static List<DownloadInfo> DownloadQueue { get; set; } = new List<DownloadInfo>();
    }

}
