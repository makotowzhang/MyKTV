using AxAPlayer3Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTV.KTVEntity;
using MyKTV.KTVCommon;
using MyKTV.KTVEnum;
using System.Windows.Forms;
using System.Threading;

namespace MyKTV.KTVBusiness
{
    public class VideoScreenShot
    {
        public static void ShotMTV(MyMTV mtv)
        {
            if (mtv == null)
            {
                return;
            }
            
            AxPlayer player = new AxPlayer();
            ((System.ComponentModel.ISupportInitialize)(player)).BeginInit();
            Form form = new Form();
            form.Controls.Add(player);
            ((System.ComponentModel.ISupportInitialize)(player)).EndInit();
            if (player.GetConfig(APlayerSnapshotConfig.SnapshotUsable.GetHashCode()) != "0")
            {
                return;
            }
            player.SetConfig(APlayerSnapshotConfig.SnapshotFormat.GetHashCode(), "2");
            player.SetConfig(APlayerSnapshotConfig.SnapshotJpegQuality.GetHashCode(), "100");
            string imgPath = PathHelper.GetScreenShotDir(mtv.Id) + mtv.MTVName + "-" + mtv.Artist + "ScreenShot";
            int unit = 0;
            player.OnOpenSucceeded += (s,e) => 
            {
                player.Pause();
               int duration = player.GetDuration();
                unit = duration / 7;
                for (int i = 1; i < 7; i++)
                {
                    player.SetPosition(unit * i);
                    Thread.Sleep(1000);
                    player.SetConfig(APlayerSnapshotConfig.SnapshotImage.GetHashCode(), imgPath + i + ".jpg");
                }
                player.Dispose();
                form.Dispose();
            };
          
            player.Open(mtv.SavePath.Replace("~",PathHelper.GetDownloadDir(Guid.Parse(mtv.Id))));
        }
    }
}
