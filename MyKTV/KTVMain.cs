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
using System.Threading;
using MyKTV.KTVStatus;
using MyKTV.KTVEnum;
using MyKTV.KTVBusiness;

namespace MyKTV
{
    public partial class KTVMain : DevExpress.XtraEditors.XtraForm
    {
        public KTVMain()
        {
            InitializeComponent();
        }

        #region 音量变更
        private Thread _volumeAdd;
        private Thread VolumeAdd
        {
            get
            {
                if (_volumeAdd == null)
                {
                    _volumeAdd = new Thread(() =>
                     {
                         while (true)
                         {
                             int volume = KTVPlayer.GetVolume();
                             if (volume < 100)
                             {
                                 KTVPlayer.SetVolume(volume + 5);
                             }
                             new Task(() =>
                             {

                                 Sprite2DShow.CreateVideoSprite(KTVPlayer, Sprite2DCommonModel.VolumeAdd(KTVPlayer.GetVolume().ToString()));

                             }).Start();
                             Thread.Sleep(150);
                         }
                     });
                }
                return _volumeAdd;
            }
            set
            {
                _volumeAdd = value;
            }
        }

        private Thread _volumeReduce;
        private Thread VolumeReduce
        {
            get
            {
                if (_volumeReduce == null)
                {
                    _volumeReduce = new Thread(() =>
                    {
                        while (true)
                        {
                            int volume = KTVPlayer.GetVolume();
                            if (volume > 0)
                            {
                                KTVPlayer.SetVolume(volume - 5);
                            }
                            new Task(() =>
                            {
                                Sprite2DShow.CreateVideoSprite(KTVPlayer, Sprite2DCommonModel.VolumeReduce(KTVPlayer.GetVolume().ToString()));
                            }).Start();
                            Thread.Sleep(150);
                        }
                    });
                }
                return _volumeReduce;
            }
            set
            {
                _volumeReduce = value;
            }
        }
        #endregion


        private void KTVMain_Load(object sender, EventArgs e)
        {
            //new Task(() => 
            //{
            //    while (true)
            //    {
            //        Sprite2DShow.DeleteVideoSprite(KTVPlayer);
            //        Thread.Sleep(500);
            //    }
            //}).Start();
            //KTVPlayer.SetVolume(50);
            //KTVPlayer.Open("http://rtm-live.glueapi.io/smil:ch001.smil/chunklist_b329000_sleng.m3u8");
            RunTimeData.VideoQueue.Add(new KTVModel.KTVQueue()
            {
                Sort = 0,
                IsPlaying = true,
                MTV = new KTVModel.MTVInfo()
                {
                    MTVName = "告白气球",
                    Artist = "周杰伦"
                }
            });
            RunTimeData.VideoQueue.Add(new KTVModel.KTVQueue()
            {
                Sort = 1,
                IsPlaying = false,
                MTV = new KTVModel.MTVInfo()
                {
                    MTVName = "唐人",
                    Artist = "孙子涵"
                }
            });
            RunTimeData.VideoQueue.Add(new KTVModel.KTVQueue()
            {
                Sort = 2,
                IsPlaying = false,
                MTV = new KTVModel.MTVInfo()
                {
                    MTVName = "巴黎夜雨",
                    Artist = "孙子涵"
                }
            });
            RunTimeData.VideoQueue.Add(new KTVModel.KTVQueue()
            {
                Sort = 3,
                IsPlaying = false,
                MTV = new KTVModel.MTVInfo()
                {
                    MTVName = "枫",
                    Artist = "周杰伦"
                }
            });
            RunTimeData.VideoQueue.Add(new KTVModel.KTVQueue()
            {
                Sort = 4,
                IsPlaying = false,
                MTV = new KTVModel.MTVInfo()
                {
                    MTVName = "全世界宣布爱你",
                    Artist = "孙子涵"
                }
            }); RunTimeData.VideoQueue.Add(new KTVModel.KTVQueue()
            {
                Sort = 5,
                IsPlaying = false,
                MTV = new KTVModel.MTVInfo()
                {
                    MTVName = "夜曲",
                    Artist = "周杰伦"
                }
            });

            foreach (var m in RunTimeData.VideoQueue)
            {
                var label = new MyKTV.UserControl.QueueLabel(m);
                label.Top = 55 * m.Sort;
                label.Width = QueueTab.Width;
                label.Click += (s, ev) => 
                {
                    RefreshQueueList();
                };
                QueueTab.Controls.Add(label);
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ColorTranslator.ToWin32(Color.White).ToString());
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (KTVPlayer.GetState() == 3)
            {
                KTVPlayer.Play();
                BtnPause.Appearance.Image = Resources.player_pause;
                BtnPause.AppearanceHovered.Image = Resources.player_pause_hover;
                BtnPause.AppearancePressed.Image = Resources.player_pause_press;
                Sprite2DShow.CreateVideoSprite(KTVPlayer, Sprite2DCommonModel.Play());
            }
            else if (KTVPlayer.GetState() == 5)
            {
                KTVPlayer.Pause();
                BtnPause.Appearance.Image = Resources.player_play;
                BtnPause.AppearanceHovered.Image = Resources.player_play_hover;
                BtnPause.AppearancePressed.Image = Resources.player_play_press;
                Sprite2DShow.CreateVideoSprite(KTVPlayer, Sprite2DCommonModel.Pause());
            }
        }

        #region 音量增加
        private void BtnVolumeAdd_MouseDown(object sender, MouseEventArgs e)
        {
            VolumeAdd.Start();
        }

        private void BtnVolumeAdd_MouseUp(object sender, MouseEventArgs e)
        {
            VolumeAdd.Abort();
            VolumeAdd = null;
        }


        private void BtnVolumeAdd_MouseLeave(object sender, EventArgs e)
        {
            VolumeAdd.Abort();
            VolumeAdd = null;
        }
        #endregion

        #region 音量减小
        private void BtnVolumeReduce_MouseDown(object sender, MouseEventArgs e)
        {
            VolumeReduce.Start();
        }

        private void BtnVolumeReduce_MouseUp(object sender, MouseEventArgs e)
        {
            VolumeReduce.Abort();
            VolumeReduce = null;
        }

        private void BtnVolumeReduce_MouseLeave(object sender, EventArgs e)
        {
            VolumeReduce.Abort();
            VolumeReduce = null;
        }
        #endregion

        private void KTVPlayer_OnMessage(object sender, AxAPlayer3Lib._IPlayerEvents_OnMessageEvent e)
        {
            if (e.nMessage == 0x203)
            {
                if (!RunTimeStatus.FullWindow)
                {
                    XtraForm fullScreenForm = new XtraForm();
                    fullScreenForm.FormBorderStyle = FormBorderStyle.None;
                    fullScreenForm.WindowState = FormWindowState.Maximized;
                    KTVPlayer.Parent = fullScreenForm;
                    fullScreenForm.Show();
                    RunTimeStatus.FullWindow = true;
                }
                else
                {
                    Control fullScreen = KTVPlayer.Parent;
                    KTVPlayer.Parent = VideoPanel;
                    fullScreen.Dispose();
                    RunTimeStatus.FullWindow = false;
                }
            }
            if (e.nMessage == 0x0201)
            {
                BtnPause_Click(null, null);
            }
        }

        private void KTVPlayer_OnEvent(object sender, AxAPlayer3Lib._IPlayerEvents_OnEventEvent e)
        {

        }
        
        #region 已点

        private void RefreshQueueList()
        {
            QueueTab.Controls.Clear();
            foreach (var m in RunTimeData.VideoQueue)
            {
                var label = new UserControl.QueueLabel(m);
                label.Top = 55 * m.Sort;
                label.Width = QueueTab.Width;
                if (m.Sort != 0)
                {
                    label.Click += (s, ev) =>
                    {
                        RefreshQueueList();
                    };
                }
                QueueTab.Controls.Add(label);
            }
        }
        #endregion

        #region 点歌

        #endregion

        #region 下载

        private void BtnMTVSearch_Click(object sender, EventArgs e)
        {
            DownSearchPanel.Controls.Clear();
            string searchStr = TextMTVSearch.Text;
            if (string.IsNullOrWhiteSpace(searchStr))
            {
                return;
            }
            else
            {
                BtnMTVSearch.Text = "搜索中";
                BtnMTVSearch.Enabled = false;
                new Task(() =>
                {
                    var list = new SearchMTV().GetMTVList(searchStr);
                    Invoke(new Action(() =>
                    {
                        int i = 0;
                        foreach (var m in list)
                        {
                            var label = new UserControl.DownloadSearchLabel(m, (i + 1).ToString());
                            label.Top = 55 * i;
                            label.Width = DownSearchPanel.Width;
                            label.DownloadAddEvent += Label_DownloadAddEvent;
                            DownSearchPanel.Controls.Add(label);
                            i++;
                        }
                        if (DownSearchPanel.VerticalScroll.Visible)
                        {
                            foreach (Control m in DownSearchPanel.Controls)
                            {
                                m.Width = m.Width - 20;
                            }
                        }
                        BtnMTVSearch.Text = "查询";
                        BtnMTVSearch.Enabled = true;
                    }));

                }).Start();
            }
        }
        #endregion

        #region 下载列表

        private void Label_DownloadAddEvent(UserControl.DownloadLabel dlabel)
        {
            dlabel.Width = TabDownloadList.Width;
            dlabel.Top = 55 * TabDownloadList.Controls.Count;
            TabDownloadList.Controls.Add(dlabel);
        } 
        #endregion

    }
}