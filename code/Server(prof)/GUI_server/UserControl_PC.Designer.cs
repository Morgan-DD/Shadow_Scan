namespace GUI_server
{
    partial class UserControl_PC
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
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_dot = new System.Windows.Forms.PictureBox();
            this.label_PcName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dot)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_User
            // 
            this.textBox_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_User.Location = new System.Drawing.Point(14, 47);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(128, 20);
            this.textBox_User.TabIndex = 1;
            this.textBox_User.Text = "USER_NAME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GUI_server.Properties.Resources.pc_icon;
            this.pictureBox1.Location = new System.Drawing.Point(160, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_dot
            // 
            this.pictureBox_dot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_dot.Image = global::GUI_server.Properties.Resources.dot_red_icon;
            this.pictureBox_dot.Location = new System.Drawing.Point(14, 110);
            this.pictureBox_dot.Name = "pictureBox_dot";
            this.pictureBox_dot.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dot.TabIndex = 2;
            this.pictureBox_dot.TabStop = false;
            // 
            // label_PcName
            // 
            this.label_PcName.AutoSize = true;
            this.label_PcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PcName.Location = new System.Drawing.Point(12, 10);
            this.label_PcName.Name = "label_PcName";
            this.label_PcName.Size = new System.Drawing.Size(130, 31);
            this.label_PcName.TabIndex = 3;
            this.label_PcName.Text = "PCNAME";
            // 
            // UserControl_PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_PcName);
            this.Controls.Add(this.pictureBox_dot);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl_PC";
            this.Size = new System.Drawing.Size(300, 150);
            this.Load += new System.EventHandler(this.UserControl_PC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.PictureBox pictureBox_dot;
        private System.Windows.Forms.Label label_PcName;
    }
}
