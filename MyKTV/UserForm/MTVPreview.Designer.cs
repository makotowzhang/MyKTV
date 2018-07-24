namespace MyKTV.UserForm
{
    partial class MTVPreview
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
            this.PicPreview = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.LabelPrev = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.LabelNext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicPreview.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicPreview
            // 
            this.PicPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicPreview.Location = new System.Drawing.Point(246, 164);
            this.PicPreview.Name = "PicPreview";
            this.PicPreview.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PicPreview.Properties.Appearance.Options.UseBackColor = true;
            this.PicPreview.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PicPreview.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicPreview.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PicPreview.Size = new System.Drawing.Size(286, 188);
            this.PicPreview.TabIndex = 0;
            this.PicPreview.ImageChanged += new System.EventHandler(this.PicPreview_ImageChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.PicPreview);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(766, 513);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.LabelPrev);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(100, 513);
            this.panelControl2.TabIndex = 2;
            // 
            // LabelPrev
            // 
            this.LabelPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelPrev.Location = new System.Drawing.Point(33, 224);
            this.LabelPrev.Name = "LabelPrev";
            this.LabelPrev.Size = new System.Drawing.Size(64, 64);
            this.LabelPrev.TabIndex = 1;
            this.LabelPrev.Click += new System.EventHandler(this.LabelPrev_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.LabelNext);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(666, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(100, 513);
            this.panelControl3.TabIndex = 2;
            // 
            // LabelNext
            // 
            this.LabelNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelNext.Location = new System.Drawing.Point(2, 225);
            this.LabelNext.Name = "LabelNext";
            this.LabelNext.Size = new System.Drawing.Size(64, 64);
            this.LabelNext.TabIndex = 0;
            this.LabelNext.Click += new System.EventHandler(this.LabelNext_Click);
            // 
            // MTVPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 513);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "MTVPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MTVPreview";
            this.SizeChanged += new System.EventHandler(this.MTVPreview_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.PicPreview.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit PicPreview;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label LabelNext;
        private System.Windows.Forms.Label LabelPrev;
    }
}