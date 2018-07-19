namespace MyKTV
{
    partial class KTVMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KTVMain));
            this.VideoPanel = new DevExpress.XtraEditors.PanelControl();
            this.KTVPlayer = new AxAPlayer3Lib.AxPlayer();
            this.MenuPanel = new DevExpress.XtraEditors.PanelControl();
            this.MenuTag = new System.Windows.Forms.TabControl();
            this.QueueTab = new System.Windows.Forms.TabPage();
            this.OrderTab = new System.Windows.Forms.TabPage();
            this.DownloadTab = new System.Windows.Forms.TabPage();
            this.DownSearchPanel = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BtnMTVSearch = new DevExpress.XtraEditors.SimpleButton();
            this.TextMTVSearch = new DevExpress.XtraEditors.TextEdit();
            this.TabDownloadList = new System.Windows.Forms.TabPage();
            this.ButtonPanel = new DevExpress.XtraEditors.PanelControl();
            this.BtnVolumeReduce = new DevExpress.XtraEditors.LabelControl();
            this.BtnVolumeAdd = new DevExpress.XtraEditors.LabelControl();
            this.BtnAcc = new DevExpress.XtraEditors.LabelControl();
            this.BtnOrg = new DevExpress.XtraEditors.LabelControl();
            this.BtnNext = new DevExpress.XtraEditors.LabelControl();
            this.BtnPause = new DevExpress.XtraEditors.LabelControl();
            this.OrderPanelTop = new DevExpress.XtraEditors.PanelControl();
            this.OrderPanelBody = new DevExpress.XtraEditors.PanelControl();
            this.OrderSearchText = new DevExpress.XtraEditors.TextEdit();
            this.OrderSearchBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPanel)).BeginInit();
            this.VideoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KTVPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPanel)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.MenuTag.SuspendLayout();
            this.OrderTab.SuspendLayout();
            this.DownloadTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextMTVSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPanel)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderPanelTop)).BeginInit();
            this.OrderPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderPanelBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSearchText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoPanel
            // 
            this.VideoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.VideoPanel.Appearance.Options.UseBackColor = true;
            this.VideoPanel.Controls.Add(this.KTVPlayer);
            this.VideoPanel.Location = new System.Drawing.Point(-1, 0);
            this.VideoPanel.Name = "VideoPanel";
            this.VideoPanel.Size = new System.Drawing.Size(691, 480);
            this.VideoPanel.TabIndex = 0;
            // 
            // KTVPlayer
            // 
            this.KTVPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KTVPlayer.Enabled = true;
            this.KTVPlayer.Location = new System.Drawing.Point(2, 2);
            this.KTVPlayer.Name = "KTVPlayer";
            this.KTVPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("KTVPlayer.OcxState")));
            this.KTVPlayer.Size = new System.Drawing.Size(687, 476);
            this.KTVPlayer.TabIndex = 0;
            this.KTVPlayer.OnMessage += new AxAPlayer3Lib._IPlayerEvents_OnMessageEventHandler(this.KTVPlayer_OnMessage);
            this.KTVPlayer.OnEvent += new AxAPlayer3Lib._IPlayerEvents_OnEventEventHandler(this.KTVPlayer_OnEvent);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Appearance.Options.UseBackColor = true;
            this.MenuPanel.Controls.Add(this.MenuTag);
            this.MenuPanel.Location = new System.Drawing.Point(689, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(301, 599);
            this.MenuPanel.TabIndex = 1;
            // 
            // MenuTag
            // 
            this.MenuTag.Controls.Add(this.QueueTab);
            this.MenuTag.Controls.Add(this.OrderTab);
            this.MenuTag.Controls.Add(this.DownloadTab);
            this.MenuTag.Controls.Add(this.TabDownloadList);
            this.MenuTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuTag.Location = new System.Drawing.Point(2, 2);
            this.MenuTag.Name = "MenuTag";
            this.MenuTag.SelectedIndex = 0;
            this.MenuTag.Size = new System.Drawing.Size(297, 595);
            this.MenuTag.TabIndex = 0;
            // 
            // QueueTab
            // 
            this.QueueTab.Location = new System.Drawing.Point(4, 23);
            this.QueueTab.Name = "QueueTab";
            this.QueueTab.Padding = new System.Windows.Forms.Padding(3);
            this.QueueTab.Size = new System.Drawing.Size(289, 568);
            this.QueueTab.TabIndex = 0;
            this.QueueTab.Text = "已点";
            this.QueueTab.UseVisualStyleBackColor = true;
            // 
            // OrderTab
            // 
            this.OrderTab.Controls.Add(this.OrderPanelBody);
            this.OrderTab.Controls.Add(this.OrderPanelTop);
            this.OrderTab.Location = new System.Drawing.Point(4, 23);
            this.OrderTab.Name = "OrderTab";
            this.OrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTab.Size = new System.Drawing.Size(289, 568);
            this.OrderTab.TabIndex = 1;
            this.OrderTab.Text = "点歌";
            this.OrderTab.UseVisualStyleBackColor = true;
            // 
            // DownloadTab
            // 
            this.DownloadTab.Controls.Add(this.DownSearchPanel);
            this.DownloadTab.Controls.Add(this.panelControl1);
            this.DownloadTab.Location = new System.Drawing.Point(4, 23);
            this.DownloadTab.Name = "DownloadTab";
            this.DownloadTab.Padding = new System.Windows.Forms.Padding(3);
            this.DownloadTab.Size = new System.Drawing.Size(289, 568);
            this.DownloadTab.TabIndex = 2;
            this.DownloadTab.Text = "下载";
            this.DownloadTab.UseVisualStyleBackColor = true;
            // 
            // DownSearchPanel
            // 
            this.DownSearchPanel.AutoScroll = true;
            this.DownSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownSearchPanel.Location = new System.Drawing.Point(3, 53);
            this.DownSearchPanel.Name = "DownSearchPanel";
            this.DownSearchPanel.Size = new System.Drawing.Size(283, 512);
            this.DownSearchPanel.TabIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.BtnMTVSearch);
            this.panelControl1.Controls.Add(this.TextMTVSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(283, 50);
            this.panelControl1.TabIndex = 3;
            // 
            // BtnMTVSearch
            // 
            this.BtnMTVSearch.Location = new System.Drawing.Point(224, 9);
            this.BtnMTVSearch.Name = "BtnMTVSearch";
            this.BtnMTVSearch.Size = new System.Drawing.Size(57, 30);
            this.BtnMTVSearch.TabIndex = 1;
            this.BtnMTVSearch.Text = "查询";
            this.BtnMTVSearch.Click += new System.EventHandler(this.BtnMTVSearch_Click);
            // 
            // TextMTVSearch
            // 
            this.TextMTVSearch.Location = new System.Drawing.Point(4, 9);
            this.TextMTVSearch.Name = "TextMTVSearch";
            this.TextMTVSearch.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMTVSearch.Properties.Appearance.Options.UseFont = true;
            this.TextMTVSearch.Size = new System.Drawing.Size(214, 30);
            this.TextMTVSearch.TabIndex = 0;
            // 
            // TabDownloadList
            // 
            this.TabDownloadList.Location = new System.Drawing.Point(4, 23);
            this.TabDownloadList.Name = "TabDownloadList";
            this.TabDownloadList.Padding = new System.Windows.Forms.Padding(3);
            this.TabDownloadList.Size = new System.Drawing.Size(289, 568);
            this.TabDownloadList.TabIndex = 3;
            this.TabDownloadList.Text = "下载列表";
            this.TabDownloadList.UseVisualStyleBackColor = true;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPanel.Appearance.Options.UseBackColor = true;
            this.ButtonPanel.Controls.Add(this.BtnVolumeReduce);
            this.ButtonPanel.Controls.Add(this.BtnVolumeAdd);
            this.ButtonPanel.Controls.Add(this.BtnAcc);
            this.ButtonPanel.Controls.Add(this.BtnOrg);
            this.ButtonPanel.Controls.Add(this.BtnNext);
            this.ButtonPanel.Controls.Add(this.BtnPause);
            this.ButtonPanel.Location = new System.Drawing.Point(-1, 476);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(691, 118);
            this.ButtonPanel.TabIndex = 2;
            // 
            // BtnVolumeReduce
            // 
            this.BtnVolumeReduce.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnVolumeReduce.Appearance.Image = global::MyKTV.Properties.Resources.volume_reduce;
            this.BtnVolumeReduce.Appearance.Options.UseImage = true;
            this.BtnVolumeReduce.AppearanceHovered.Image = global::MyKTV.Properties.Resources.volume_reduce_hover;
            this.BtnVolumeReduce.AppearanceHovered.Options.UseImage = true;
            this.BtnVolumeReduce.AppearancePressed.Image = global::MyKTV.Properties.Resources.volume_reduce_press;
            this.BtnVolumeReduce.AppearancePressed.Options.UseImage = true;
            this.BtnVolumeReduce.Location = new System.Drawing.Point(194, 30);
            this.BtnVolumeReduce.Name = "BtnVolumeReduce";
            this.BtnVolumeReduce.Size = new System.Drawing.Size(64, 64);
            this.BtnVolumeReduce.TabIndex = 7;
            this.BtnVolumeReduce.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnVolumeReduce_MouseDown);
            this.BtnVolumeReduce.MouseLeave += new System.EventHandler(this.BtnVolumeReduce_MouseLeave);
            this.BtnVolumeReduce.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnVolumeReduce_MouseUp);
            // 
            // BtnVolumeAdd
            // 
            this.BtnVolumeAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnVolumeAdd.Appearance.Image = global::MyKTV.Properties.Resources.volume_add;
            this.BtnVolumeAdd.Appearance.Options.UseImage = true;
            this.BtnVolumeAdd.AppearanceHovered.Image = global::MyKTV.Properties.Resources.volume_add_hover;
            this.BtnVolumeAdd.AppearanceHovered.Options.UseImage = true;
            this.BtnVolumeAdd.AppearancePressed.Image = global::MyKTV.Properties.Resources.volume_add_press;
            this.BtnVolumeAdd.AppearancePressed.Options.UseImage = true;
            this.BtnVolumeAdd.Location = new System.Drawing.Point(110, 30);
            this.BtnVolumeAdd.Name = "BtnVolumeAdd";
            this.BtnVolumeAdd.Size = new System.Drawing.Size(64, 64);
            this.BtnVolumeAdd.TabIndex = 6;
            this.BtnVolumeAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnVolumeAdd_MouseDown);
            this.BtnVolumeAdd.MouseLeave += new System.EventHandler(this.BtnVolumeAdd_MouseLeave);
            this.BtnVolumeAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnVolumeAdd_MouseUp);
            // 
            // BtnAcc
            // 
            this.BtnAcc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnAcc.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAcc.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnAcc.Appearance.Image = global::MyKTV.Properties.Resources.dark_blue_button_s;
            this.BtnAcc.Appearance.Options.UseFont = true;
            this.BtnAcc.Appearance.Options.UseForeColor = true;
            this.BtnAcc.Appearance.Options.UseImage = true;
            this.BtnAcc.AppearanceHovered.Image = global::MyKTV.Properties.Resources.orange_button_s;
            this.BtnAcc.AppearanceHovered.Options.UseImage = true;
            this.BtnAcc.AppearancePressed.Image = global::MyKTV.Properties.Resources.green_button_s;
            this.BtnAcc.AppearancePressed.Options.UseImage = true;
            this.BtnAcc.Location = new System.Drawing.Point(461, 27);
            this.BtnAcc.Name = "BtnAcc";
            this.BtnAcc.Size = new System.Drawing.Size(64, 64);
            this.BtnAcc.TabIndex = 5;
            this.BtnAcc.Text = "  伴唱";
            // 
            // BtnOrg
            // 
            this.BtnOrg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnOrg.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOrg.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnOrg.Appearance.Image = global::MyKTV.Properties.Resources.dark_blue_button_s;
            this.BtnOrg.Appearance.Options.UseFont = true;
            this.BtnOrg.Appearance.Options.UseForeColor = true;
            this.BtnOrg.Appearance.Options.UseImage = true;
            this.BtnOrg.AppearanceHovered.Image = global::MyKTV.Properties.Resources.orange_button_s;
            this.BtnOrg.AppearanceHovered.Options.UseImage = true;
            this.BtnOrg.AppearancePressed.Image = global::MyKTV.Properties.Resources.green_button_s;
            this.BtnOrg.AppearancePressed.Options.UseImage = true;
            this.BtnOrg.Location = new System.Drawing.Point(374, 27);
            this.BtnOrg.Name = "BtnOrg";
            this.BtnOrg.Size = new System.Drawing.Size(64, 64);
            this.BtnOrg.TabIndex = 4;
            this.BtnOrg.Text = "  原唱";
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnNext.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnNext.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnNext.Appearance.Image = global::MyKTV.Properties.Resources.dark_blue_button_s;
            this.BtnNext.Appearance.Options.UseFont = true;
            this.BtnNext.Appearance.Options.UseForeColor = true;
            this.BtnNext.Appearance.Options.UseImage = true;
            this.BtnNext.AppearanceHovered.Image = global::MyKTV.Properties.Resources.orange_button_s;
            this.BtnNext.AppearanceHovered.Options.UseImage = true;
            this.BtnNext.AppearancePressed.Image = global::MyKTV.Properties.Resources.green_button_s;
            this.BtnNext.AppearancePressed.Options.UseImage = true;
            this.BtnNext.Location = new System.Drawing.Point(280, 27);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(64, 64);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "  切歌";
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnPause.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("BtnPause.Appearance.Image")));
            this.BtnPause.Appearance.Options.UseImage = true;
            this.BtnPause.AppearanceHovered.Image = global::MyKTV.Properties.Resources.player_pause_hover;
            this.BtnPause.AppearanceHovered.Options.UseImage = true;
            this.BtnPause.AppearancePressed.Image = global::MyKTV.Properties.Resources.player_pause_press;
            this.BtnPause.AppearancePressed.Options.UseImage = true;
            this.BtnPause.Location = new System.Drawing.Point(30, 30);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(64, 64);
            this.BtnPause.TabIndex = 0;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // OrderPanelTop
            // 
            this.OrderPanelTop.Appearance.BackColor = System.Drawing.Color.White;
            this.OrderPanelTop.Appearance.Options.UseBackColor = true;
            this.OrderPanelTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.OrderPanelTop.Controls.Add(this.OrderSearchBtn);
            this.OrderPanelTop.Controls.Add(this.OrderSearchText);
            this.OrderPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderPanelTop.Location = new System.Drawing.Point(3, 3);
            this.OrderPanelTop.Name = "OrderPanelTop";
            this.OrderPanelTop.Size = new System.Drawing.Size(283, 50);
            this.OrderPanelTop.TabIndex = 0;
            // 
            // OrderPanelBody
            // 
            this.OrderPanelBody.Appearance.BackColor = System.Drawing.Color.White;
            this.OrderPanelBody.Appearance.Options.UseBackColor = true;
            this.OrderPanelBody.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.OrderPanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderPanelBody.Location = new System.Drawing.Point(3, 53);
            this.OrderPanelBody.Name = "OrderPanelBody";
            this.OrderPanelBody.Size = new System.Drawing.Size(283, 512);
            this.OrderPanelBody.TabIndex = 1;
            // 
            // OrderSearchText
            // 
            this.OrderSearchText.Location = new System.Drawing.Point(4, 9);
            this.OrderSearchText.Name = "OrderSearchText";
            this.OrderSearchText.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSearchText.Properties.Appearance.Options.UseFont = true;
            this.OrderSearchText.Size = new System.Drawing.Size(214, 30);
            this.OrderSearchText.TabIndex = 1;
            // 
            // OrderSearchBtn
            // 
            this.OrderSearchBtn.Location = new System.Drawing.Point(224, 9);
            this.OrderSearchBtn.Name = "OrderSearchBtn";
            this.OrderSearchBtn.Size = new System.Drawing.Size(57, 30);
            this.OrderSearchBtn.TabIndex = 2;
            this.OrderSearchBtn.Text = "搜索";
            this.OrderSearchBtn.Click += new System.EventHandler(this.OrderSearchBtn_Click);
            // 
            // KTVMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 593);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.VideoPanel);
            this.KeyPreview = true;
            this.Name = "KTVMain";
            this.Text = "KTVMain";
            this.Load += new System.EventHandler(this.KTVMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VideoPanel)).EndInit();
            this.VideoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KTVPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPanel)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuTag.ResumeLayout(false);
            this.OrderTab.ResumeLayout(false);
            this.DownloadTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextMTVSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPanel)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderPanelTop)).EndInit();
            this.OrderPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderPanelBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSearchText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl VideoPanel;
        private AxAPlayer3Lib.AxPlayer KTVPlayer;
        private DevExpress.XtraEditors.PanelControl MenuPanel;
        private System.Windows.Forms.TabControl MenuTag;
        private System.Windows.Forms.TabPage QueueTab;
        private System.Windows.Forms.TabPage OrderTab;
        private System.Windows.Forms.TabPage DownloadTab;
        private DevExpress.XtraEditors.PanelControl ButtonPanel;
        private DevExpress.XtraEditors.LabelControl BtnPause;
        private DevExpress.XtraEditors.LabelControl BtnNext;
        private DevExpress.XtraEditors.LabelControl BtnAcc;
        private DevExpress.XtraEditors.LabelControl BtnOrg;
        private DevExpress.XtraEditors.LabelControl BtnVolumeReduce;
        private DevExpress.XtraEditors.LabelControl BtnVolumeAdd;
        private DevExpress.XtraEditors.SimpleButton BtnMTVSearch;
        private DevExpress.XtraEditors.TextEdit TextMTVSearch;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel DownSearchPanel;
        private System.Windows.Forms.TabPage TabDownloadList;
        private DevExpress.XtraEditors.PanelControl OrderPanelBody;
        private DevExpress.XtraEditors.PanelControl OrderPanelTop;
        private DevExpress.XtraEditors.SimpleButton OrderSearchBtn;
        private DevExpress.XtraEditors.TextEdit OrderSearchText;
    }
}