namespace MyKTV.UserControl
{
    partial class OrderLabel
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
            this.LabelOrder = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Appearance.Options.UseFont = true;
            this.labelName.Location = new System.Drawing.Point(33, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 21);
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
            this.labelSort.Location = new System.Drawing.Point(10, 18);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(31, 21);
            this.labelSort.TabIndex = 4;
            this.labelSort.Text = "Sort";
            // 
            // LabelOrder
            // 
            this.LabelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelOrder.Appearance.BackColor = System.Drawing.Color.Red;
            this.LabelOrder.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelOrder.Appearance.ForeColor = System.Drawing.Color.White;
            this.LabelOrder.Appearance.Options.UseBackColor = true;
            this.LabelOrder.Appearance.Options.UseFont = true;
            this.LabelOrder.Appearance.Options.UseForeColor = true;
            this.LabelOrder.Location = new System.Drawing.Point(207, 13);
            this.LabelOrder.Name = "LabelOrder";
            this.LabelOrder.Size = new System.Drawing.Size(21, 28);
            this.LabelOrder.TabIndex = 6;
            this.LabelOrder.Text = "点";
            // 
            // OrderLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelOrder);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSort);
            this.Name = "OrderLabel";
            this.Size = new System.Drawing.Size(248, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelName;
        private DevExpress.XtraEditors.LabelControl labelSort;
        private DevExpress.XtraEditors.LabelControl LabelOrder;
    }
}
