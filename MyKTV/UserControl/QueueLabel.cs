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
using MyKTV.KTVStatus;

namespace MyKTV.UserControl
{
    public partial class QueueLabel : DevExpress.XtraEditors.XtraUserControl
    {
        private int QueueSort { get; set; }
        public QueueLabel(KTVQueue model)
        {
            InitializeComponent();

            if ((model.Sort % 2) == 0)
            {
                Appearance.BackColor = Color.White;
            }
            else
            {
                Appearance.BackColor = Color.FromArgb(191, 239, 255);
            }
            if (model.IsPlaying)
            {
                Appearance.BackColor = Color.FromArgb(124, 252, 00);
            }
            labelSort.Text = (model.Sort+1).ToString();
            labelName.Text = model.MTV.MTVName + "-" + model.MTV.Artist;
            QueueSort = model.Sort;
        }

        private void QueueLabel_Load(object sender, EventArgs e)
        {
           

        }

        private void QueueLabel_Click(object sender, EventArgs e)
        {
            lock (RunTimeData.VideoQueue)
            {
                if (QueueSort == 0)
                {
                    return;
                }
                var temp = RunTimeData.VideoQueue.FirstOrDefault(m => m.Sort == QueueSort);
                foreach (var m in RunTimeData.VideoQueue.Where(m => m.Sort > 0 && m.Sort < QueueSort))
                {
                    m.Sort++;
                }
                temp.Sort = 1;
                QueueSort = 1;
            }
        }
    }
}
