namespace MyKTV.UserControl
{
    partial class DownloadSearchLabel
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
            this.LabelServerDownload = new DevExpress.XtraEditors.LabelControl();
            this.LabelCloudDownload = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Appearance.Options.UseFont = true;
            this.labelName.Location = new System.Drawing.Point(26, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 20);
            this.labelName.TabIndex = 3;
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
            this.labelSort.Location = new System.Drawing.Point(3, 18);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(31, 20);
            this.labelSort.TabIndex = 2;
            this.labelSort.Text = "Sort";
            // 
            // LabelServerDownload
            // 
            this.LabelServerDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelServerDownload.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelServerDownload.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.LabelServerDownload.Appearance.ForeColor = System.Drawing.Color.White;
            this.LabelServerDownload.Appearance.Options.UseBackColor = true;
            this.LabelServerDownload.Appearance.Options.UseFont = true;
            this.LabelServerDownload.Appearance.Options.UseForeColor = true;
            this.LabelServerDownload.Location = new System.Drawing.Point(213, 13);
            this.LabelServerDownload.Name = "LabelServerDownload";
            this.LabelServerDownload.Size = new System.Drawing.Size(21, 26);
            this.LabelServerDownload.TabIndex = 4;
            this.LabelServerDownload.Text = "服";
            this.LabelServerDownload.Click += new System.EventHandler(this.LabelServerDownload_Click);
            // 
            // LabelCloudDownload
            // 
            this.LabelCloudDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCloudDownload.Appearance.BackColor = System.Drawing.Color.Blue;
            this.LabelCloudDownload.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelCloudDownload.Appearance.ForeColor = System.Drawing.Color.White;
            this.LabelCloudDownload.Appearance.Options.UseBackColor = true;
            this.LabelCloudDownload.Appearance.Options.UseFont = true;
            this.LabelCloudDownload.Appearance.Options.UseForeColor = true;
            this.LabelCloudDownload.Location = new System.Drawing.Point(178, 13);
            this.LabelCloudDownload.Name = "LabelCloudDownload";
            this.LabelCloudDownload.Size = new System.Drawing.Size(21, 26);
            this.LabelCloudDownload.TabIndex = 5;
            this.LabelCloudDownload.Text = "云";
            this.LabelCloudDownload.Click += new System.EventHandler(this.LabelCloudDownload_Click);
            // 
            // DownloadSearchLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelCloudDownload);
            this.Controls.Add(this.LabelServerDownload);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSort);
            this.Name = "DownloadSearchLabel";
            this.Size = new System.Drawing.Size(248, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelName;
        private DevExpress.XtraEditors.LabelControl labelSort;
        private DevExpress.XtraEditors.LabelControl LabelServerDownload;
        private DevExpress.XtraEditors.LabelControl LabelCloudDownload;
    }
}
