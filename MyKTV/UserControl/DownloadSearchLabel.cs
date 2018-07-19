using MyKTV.KTVBusiness;
using MyKTV.KTVCommon;
using MyKTV.KTVEntity;
using MyKTV.KTVModel;
using MyKTV.KTVStatus;
using System;
using System.Drawing;
using System.Linq;

namespace MyKTV.UserControl
{
    public partial class DownloadSearchLabel : DevExpress.XtraEditors.XtraUserControl
    {
        private MTVInfo mtvInfo { get; set; }
        
        public delegate void DonwloadAddHandler(DownloadLabel dlabel);

        public event DonwloadAddHandler DownloadAddEvent;

        public DownloadSearchLabel(MTVInfo mtv,string sort)
        {
            InitializeComponent();
            labelSort.Text = sort;
            labelName.Text = mtv.MTVName + "-" + mtv.Artist;
            mtvInfo = mtv;
            mtvInfo.Id = Guid.NewGuid();
            using (KTVDataBase db = new KTVDataBase())
            {
                if (db.MyMTV.Any(m => m.DetailUrl == mtv.DetailUrl) || RunTimeData.DownloadQueue.Any(m => m.MTV.DetailUrl == mtv.DetailUrl))
                {
                    LabelServerDownload.Visible = false;
                    LabelCloudDownload.Visible = false;
                }
            }
            if (int.Parse(sort) % 2==0)
            {
                Appearance.BackColor = Color.FromArgb(204, 204, 204);
            }
        }

        private void LabelCloudDownload_Click(object sender, EventArgs e)
        {
            LabelServerDownload.Visible = false;
            LabelCloudDownload.Visible = false;
            DownloadInfo dinfo = new DownloadInfo()
            {
                MTV = mtvInfo,
                DownloadType = KTVEnum.MTVDownloadType.Cloud,
                WebUrl = mtvInfo.CloudDiskUrl,
                SavePath = PathHelper.GetDownloadDir(mtvInfo.Id)  + mtvInfo.MTVName + "-" + mtvInfo.Artist + ".mkv",
                Sort = RunTimeData.DownloadQueue.Count > 0 ? RunTimeData.DownloadQueue.Max(m => m.Sort) + 1 : 1
            };
            DownloadLabel dlabel = new DownloadLabel(dinfo);
            if (DownloadAddEvent != null)
            {
                DownloadAddEvent.Invoke(dlabel);
            }
            RunTimeData.DownloadQueue.Add(dinfo);
            DownLoadMTV.BeginDownload();
        }

        private void LabelServerDownload_Click(object sender, EventArgs e)
        {
            LabelServerDownload.Visible = false;
            LabelCloudDownload.Visible = false;
            DownloadInfo dinfo = new DownloadInfo()
            {
                MTV = mtvInfo,
                DownloadType = KTVEnum.MTVDownloadType.Server,
                WebUrl = mtvInfo.CloudDiskUrl,
                SavePath = PathHelper.GetDownloadDir(mtvInfo.Id) + mtvInfo.MTVName + "-" + mtvInfo.Artist + ".mkv",
                Sort = RunTimeData.DownloadQueue.Count > 0 ? RunTimeData.DownloadQueue.Max(m => m.Sort) + 1 : 1
            };
            DownloadLabel dlabel = new DownloadLabel(dinfo);
            if (DownloadAddEvent != null)
            {
                DownloadAddEvent.Invoke(dlabel);
            }
            RunTimeData.DownloadQueue.Add(dinfo);
            DownLoadMTV.BeginDownload();
        }
    }
}
