namespace MyKTV.UserControl
{
    partial class QueueLabel
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
            this.labelSort = new DevExpress.XtraEditors.LabelControl();
            this.labelName = new DevExpress.XtraEditors.LabelControl();
            this.GoTop = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelSort
            // 
            this.labelSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSort.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSort.Appearance.Options.UseFont = true;
            this.labelSort.Location = new System.Drawing.Point(6, 18);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(31, 20);
            this.labelSort.TabIndex = 0;
            this.labelSort.Text = "Sort";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Appearance.Options.UseFont = true;
            this.labelName.Location = new System.Drawing.Point(29, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // GoTop
            // 
            this.GoTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoTop.Appearance.BackColor = System.Drawing.Color.Red;
            this.GoTop.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoTop.Appearance.ForeColor = System.Drawing.Color.White;
            this.GoTop.Appearance.Options.UseBackColor = true;
            this.GoTop.Appearance.Options.UseFont = true;
            this.GoTop.Appearance.Options.UseForeColor = true;
            this.GoTop.Location = new System.Drawing.Point(211, 13);
            this.GoTop.Name = "GoTop";
            this.GoTop.Size = new System.Drawing.Size(21, 26);
            this.GoTop.TabIndex = 7;
            this.GoTop.Text = "顶";
            this.GoTop.Click += new System.EventHandler(this.GoTop_Click);
            // 
            // QueueLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GoTop);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSort);
            this.Name = "QueueLabel";
            this.Size = new System.Drawing.Size(259, 55);
            this.Load += new System.EventHandler(this.QueueLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelSort;
        private DevExpress.XtraEditors.LabelControl labelName;
        private DevExpress.XtraEditors.LabelControl GoTop;
    }
}
