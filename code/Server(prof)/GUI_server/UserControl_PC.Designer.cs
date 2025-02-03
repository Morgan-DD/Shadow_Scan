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
            this.label_PcName = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.pictureBox_dot = new System.Windows.Forms.PictureBox();
            this.id_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dot)).BeginInit();
            this.SuspendLayout();
            // 
            // label_PcName
            // 
            this.label_PcName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PcName.AutoSize = true;
            this.label_PcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PcName.Location = new System.Drawing.Point(10, 9);
            this.label_PcName.Name = "label_PcName";
            this.label_PcName.Size = new System.Drawing.Size(139, 25);
            this.label_PcName.TabIndex = 0;
            this.label_PcName.Text = "label_PcName";
            this.label_PcName.Click += new System.EventHandler(this.Click_Event);
            // 
            // textBox_User
            // 
            this.textBox_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_User.Location = new System.Drawing.Point(25, 37);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(125, 20);
            this.textBox_User.TabIndex = 1;
            // 
            // pictureBox_dot
            // 
            this.pictureBox_dot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_dot.Image = global::GUI_server.Properties.Resources.dot_red_icon;
            this.pictureBox_dot.Location = new System.Drawing.Point(72, 65);
            this.pictureBox_dot.Name = "pictureBox_dot";
            this.pictureBox_dot.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dot.TabIndex = 2;
            this.pictureBox_dot.TabStop = false;
            this.pictureBox_dot.Click += new System.EventHandler(this.Click_Event);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(97, 65);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(35, 13);
            this.id_label.TabIndex = 3;
            this.id_label.Text = "label1";
            // 
            // UserControl_PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.pictureBox_dot);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.label_PcName);
            this.Name = "UserControl_PC";
            this.Size = new System.Drawing.Size(175, 105);
            this.Click += new System.EventHandler(this.Click_Event);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PcName;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.PictureBox pictureBox_dot;
        private System.Windows.Forms.Label id_label;
    }
}
