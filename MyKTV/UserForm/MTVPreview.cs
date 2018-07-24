using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyKTV.Properties;
using MyKTV.KTVEntity;
using MyKTV.KTVCommon;
using System.IO;

namespace MyKTV.UserForm
{
    public partial class MTVPreview : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<int, Bitmap> Bitmaps { get; set; } = new Dictionary<int, Bitmap>();

        private int BitmapsIndex { get; set; } = 0;

        private static MTVPreview Previewer { get; set; }

        private MTVPreview()
        {
            InitializeComponent();
            LabelNext.Image = Resources.PicArrow;
            Image prev = Resources.PicArrow.Clone() as Image;
            prev.RotateFlip(RotateFlipType.Rotate90FlipX);
            prev.RotateFlip(RotateFlipType.Rotate90FlipY);
            LabelPrev.Image = prev;
        }

        public static MTVPreview GetViewer(MyMTV mtv)
        {
            if (Previewer == null)
            {
                Previewer = new MTVPreview();
            }
            else
            {
                Previewer.Dispose();
                Previewer = new MTVPreview();
            }
            Previewer.InitData(mtv.Id);
            return Previewer;
        }

        private void MTVPreview_SizeChanged(object sender, EventArgs e)
        {
            LabelNext.Top = (LabelNext.Parent.Size.Height - 64) / 2;
            LabelPrev.Top = (LabelPrev.Parent.Size.Height - 64) / 2;
            PicPreview_ImageChanged(sender, e);
        }

        private void LabelNext_Click(object sender, EventArgs e)
        {
            BitmapsIndex++;
            if (!Bitmaps.Keys.Any(m => m == BitmapsIndex))
            {
                BitmapsIndex = 0;
                if (!Bitmaps.Keys.Any(m => m == BitmapsIndex))
                {
                    XtraMessageBox.Show("没有可以预览的图片");
                    return;
                }
            }
            PicPreview.Image = Bitmaps[BitmapsIndex];
        }

        private void LabelPrev_Click(object sender, EventArgs e)
        {
            BitmapsIndex--;
            if (!Bitmaps.Keys.Any(m => m == BitmapsIndex))
            {
                BitmapsIndex = Bitmaps.Count - 1;
                if (!Bitmaps.Keys.Any(m => m == BitmapsIndex))
                {
                    XtraMessageBox.Show("没有可以预览的图片");
                    return;
                }
            }
            PicPreview.Image = Bitmaps[BitmapsIndex];
        }

        private void PicPreview_ImageChanged(object sender, EventArgs e)
        {
            if (PicPreview.Image == null)
            {
                PicPreview.Left = (PicPreview.Parent.Width - PicPreview.Width) / 2;
                PicPreview.Top = (PicPreview.Parent.Height - PicPreview.Height) / 2;
                return;
            }
            int pWidth = PicPreview.Parent.Width - 20;
            int pHeight = PicPreview.Parent.Height - 20;
            int imgWidth = PicPreview.Image.Size.Width;
            int imgHeight = PicPreview.Image.Size.Height;
            if (imgWidth <= pWidth && imgHeight <= pHeight)
            {
                PicPreview.Width = imgWidth;
                PicPreview.Height = imgHeight;

            }
            if (imgWidth > pWidth && imgHeight < pHeight)
            {
                PicPreview.Width = pWidth;
                PicPreview.Height = (pWidth * imgHeight) / imgWidth;
            }
            if (imgWidth < pWidth && imgHeight > pHeight)
            {
                PicPreview.Width = pHeight * imgWidth / imgHeight;
                PicPreview.Height = pHeight;
            }
            if (imgWidth > pWidth && imgHeight > pHeight)
            {
                if ((pWidth * imgHeight / imgWidth) <= pHeight)
                {
                    PicPreview.Width = pWidth;
                    PicPreview.Height = (pWidth * imgHeight) / imgWidth;
                }
                else
                {
                    PicPreview.Width = pHeight * imgWidth / imgHeight;
                    PicPreview.Height = pHeight;
                }
            }
            PicPreview.Left = (PicPreview.Parent.Width - PicPreview.Width) / 2;
            PicPreview.Top = (PicPreview.Parent.Height - PicPreview.Height) / 2;
        }

        private void InitData(string id)
        {
            Bitmaps.Clear();
            BitmapsIndex = 0;
            string dir= PathHelper.GetScreenShotDir(id);
            var files = Directory.GetFiles(dir, "*.jpg");
            if (files.Length > 0)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    Bitmaps.Add(i,new Bitmap(files[i]));
                }
                PicPreview.Image = Bitmaps[0];
            }
        }
    }
}