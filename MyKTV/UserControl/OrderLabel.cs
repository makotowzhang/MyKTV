using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyKTV.KTVEntity;
using MyKTV.KTVStatus;
using MyKTV.KTVModel;

namespace MyKTV.UserControl
{
    public partial class OrderLabel : DevExpress.XtraEditors.XtraUserControl
    {
        private MyMTV OrderMTV { get; set; }
        public OrderLabel(MyMTV mtv)
        {
            InitializeComponent();
            OrderMTV = mtv;
            if (RunTimeData.VideoQueue.Any(m => m.MTV.Id == Guid.Parse(OrderMTV.Id)))
            {
                LabelOrder.Appearance.BackColor = Color.Green;
            }
        }

        private void LabelOrder_Click(object sender, EventArgs e)
        {
            lock (RunTimeData.VideoQueue)
            {
                int sort = RunTimeData.VideoQueue.Count();
                RunTimeData.VideoQueue.Add(new KTVQueue()
                {
                    IsPlaying=false,
                    Sort=sort,
                    MTV=new MTVInfo()
                    {
                        Id = Guid.Parse(OrderMTV.Id),
                        Artist = OrderMTV.Artist,
                        CloudDiskUrl = OrderMTV.CloudDiskUrl,
                        DetailUrl = OrderMTV.DetailUrl,
                        ED2KUrl = OrderMTV.ED2KUrl,
                        FileName = OrderMTV.FileName,
                        LocalImagePath = OrderMTV.LocalImagePath,
                        MTVImage = OrderMTV.MTVImage,
                        MTVName = OrderMTV.MTVName,
                        MTVSize = OrderMTV.MTVSize,
                        SavePath = OrderMTV.SavePath,
                        ServerUrl = OrderMTV.ServerUrl,
                        SouceFileName = OrderMTV.SouceFileName
                    }
                });
                LabelOrder.Appearance.BackColor = Color.Green;
            }
        }
    }
}
