namespace MyKTV.UserControl
{
    partial class DownloadLabel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new DevExpress.XtraEditors.LabelControl();
            this.labelSort = new DevExpress.XtraEditors.LabelControl();
            this.DownloadProgress = new DevExpress.XtraEditors.ProgressBarControl();
            this.LabelProgress = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadProgress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Appearance.Options.UseFont = true;
            this.labelName.Location = new System.Drawing.Point(27, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 20);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelSort
            // 
            this.labelSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSort.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelSort.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSort.Appearance.Options.UseBackColor = true;
            this.labelSort.Appearance.Options.UseFont = true;
            this.labelSort.Location = new System.Drawing.Point(3, 3);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(31, 20);
            this.labelSort.TabIndex = 4;
            this.labelSort.Text = "Sort";
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadProgress.Location = new System.Drawing.Point(13, 29);
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.Size = new System.Drawing.Size(186, 18);
            this.DownloadProgress.TabIndex = 6;
            // 
            // LabelProgress
            // 
            this.LabelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelProgress.Location = new System.Drawing.Point(202, 30);
            this.LabelProgress.Name = "LabelProgress";
            this.LabelProgress.Size = new System.Drawing.Size(36, 14);
            this.LabelProgress.TabIndex = 7;
            this.LabelProgress.Text = "等待中";
            // 
            // DownloadLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelProgress);
            this.Controls.Add(this.DownloadProgress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSort);
            this.Name = "DownloadLabel";
            this.Size = new System.Drawing.Size(241, 55);
            ((System.ComponentModel.ISupportInitialize)(this.DownloadProgress.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelName;
        private DevExpress.XtraEditors.LabelControl labelSort;
        private DevExpress.XtraEditors.ProgressBarControl DownloadProgress;
        private DevExpress.XtraEditors.LabelControl LabelProgress;
    }
}
