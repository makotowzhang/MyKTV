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
using MyKTV.KTVModel;

namespace MyKTV.UserControl
{
    public partial class DownloadLabel : DevExpress.XtraEditors.XtraUserControl
    {
        private DownloadInfo Model { get; set; }
        public DownloadLabel(DownloadInfo info)
        {
            InitializeComponent();
            labelSort.Text = info.Sort.ToString();
            labelName.Text = info.MTV.MTVName+"-"+info.MTV.Artist;
            info.ProcessChange = new System.Net.DownloadProgressChangedEventHandler((s,e)=> 
            {
                Invoke(new Action(()=> 
                {
                    DownloadProgress.Position = e.ProgressPercentage;
                    LabelProgress.Text = e.ProgressPercentage + "%";
                } ));
            });
            info.Complete = new AsyncCompletedEventHandler((s, e) =>
            {
                this.Appearance.BackColor = Color.LightGreen;
            });
        }
    }
}
