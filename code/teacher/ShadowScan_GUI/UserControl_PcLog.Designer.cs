namespace ShadowScan_GUI
{
    partial class UserControl_PcLog
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
            this.label_PcLogs = new System.Windows.Forms.Label();
            this.textBox_PcLogs = new System.Windows.Forms.TextBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // label_PcLogs
            // 
            this.label_PcLogs.AutoSize = true;
            this.label_PcLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PcLogs.Location = new System.Drawing.Point(35, 11);
            this.label_PcLogs.Name = "label_PcLogs";
            this.label_PcLogs.Size = new System.Drawing.Size(81, 25);
            this.label_PcLogs.TabIndex = 1;
            this.label_PcLogs.Text = "PC logs";
            // 
            // textBox_PcLogs
            // 
            this.textBox_PcLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PcLogs.Location = new System.Drawing.Point(3, 39);
            this.textBox_PcLogs.Multiline = true;
            this.textBox_PcLogs.Name = "textBox_PcLogs";
            this.textBox_PcLogs.ReadOnly = true;
            this.textBox_PcLogs.Size = new System.Drawing.Size(144, 108);
            this.textBox_PcLogs.TabIndex = 2;
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Close.Image = global::ShadowScan_GUI.Properties.Resources.close_icon;
            this.pictureBox_Close.Location = new System.Drawing.Point(127, 3);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 23;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // UserControl_PcLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.textBox_PcLogs);
            this.Controls.Add(this.label_PcLogs);
            this.Name = "UserControl_PcLog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PcLogs;
        private System.Windows.Forms.TextBox textBox_PcLogs;
        private System.Windows.Forms.PictureBox pictureBox_Close;
    }
}
