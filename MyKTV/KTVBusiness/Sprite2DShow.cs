using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTV.KTVModel;
using MyKTV.KTVEnum;
using MyKTV.KTVStatus;
using MyKTV.Properties;
using System.Drawing;

namespace MyKTV.KTVBusiness
{
    public class Sprite2DShow
    {
        public static bool CreateVideoSprite(AxAPlayer3Lib.AxPlayer player, List<Sprite2D> sprite)
        {
            try
            {
                lock (RunTimeData.VideoSprite)
                {
                    if (sprite.Any(m => m.IsOnly))
                    {

                        foreach (Sprite2D s in RunTimeData.VideoSprite.Where(m => m.IsOnly))
                        {
                            player.SetConfig((int)APlayerSprite2DConfig.SpriteDelete, s.Id.ToString());

                        }
                        RunTimeData.VideoSprite.RemoveAll(m => m.IsOnly);
                    }
                    foreach (var s in sprite)
                    {
                        s.Id = player.SetConfig((int)APlayerSprite2DConfig.SpriteAdd, s.ToString());
                        player.SetConfig((int)APlayerSprite2DConfig.SpritePosition, s.Left + ";" + s.Top);
                        RunTimeData.VideoSprite.Add(s);
                    }
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public static bool DeleteVideoSprite(AxAPlayer3Lib.AxPlayer player)
        {
            try
            {
                lock (RunTimeData.VideoSprite)
                {
                    foreach (var s in RunTimeData.VideoSprite.Where(m => m.IsNeedRemove))
                    {
                        player.SetConfig((int)APlayerSprite2DConfig.SpriteDelete, s.Id.ToString());
                        
                    }
                    RunTimeData.VideoSprite.RemoveAll(m=>m.IsNeedRemove);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class Sprite2DCommonModel
    {
        public static List<Sprite2D> VolumeAdd(string volume)
        {
            return GetIconSprite(Resources.volume_add_sprite, volume);
        }

        public static List<Sprite2D> VolumeReduce(string volume)
        {
            return GetIconSprite(Resources.volume_reduce_sprite, volume);
        }

        public static List<Sprite2D> Play()
        {
            return GetIconSprite(Resources.play_sprite, "播放");
        }

        public static List<Sprite2D> Pause()
        {
            return GetIconSprite(Resources.pause_sprite, "暂停");
        }

        public static List<Sprite2D> GetIconSprite(Bitmap img,string text)
        {
            Sprite2D addIcon = new Sprite2D(true)
            {
                Type = Sprite2DType.image,
                Image = img,
                IsOnly = true
            };
            Sprite2D addValue = new Sprite2D(true)
            {
                Type = Sprite2DType.text,
                Text = text,
                Left = 110,
                Top = 50,
                IsOnly = true
            };
            return new List<Sprite2D>() { addIcon, addValue };
        }
    }
}
