namespace ShadowScan_GUI
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
            label_PcName = new Label();
            textBox_User = new TextBox();
            pictureBox_dot = new PictureBox();
            label_status = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_dot).BeginInit();
            SuspendLayout();
            // 
            // label_PcName
            // 
            label_PcName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_PcName.AutoSize = true;
            label_PcName.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_PcName.Location = new Point(12, 10);
            label_PcName.Margin = new Padding(4, 0, 4, 0);
            label_PcName.Name = "label_PcName";
            label_PcName.Size = new Size(139, 25);
            label_PcName.TabIndex = 0;
            label_PcName.Text = "label_PcName";
            label_PcName.Click += Click_Event;
            // 
            // textBox_User
            // 
            textBox_User.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_User.Location = new Point(18, 43);
            textBox_User.Margin = new Padding(4, 3, 4, 3);
            textBox_User.Name = "textBox_User";
            textBox_User.ReadOnly = true;
            textBox_User.Size = new Size(171, 23);
            textBox_User.TabIndex = 1;
            // 
            // pictureBox_dot
            // 
            pictureBox_dot.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox_dot.Image = Properties.Resources.dot_red_icon;
            pictureBox_dot.Location = new Point(18, 73);
            pictureBox_dot.Margin = new Padding(4, 3, 4, 3);
            pictureBox_dot.Name = "pictureBox_dot";
            pictureBox_dot.Size = new Size(35, 35);
            pictureBox_dot.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_dot.TabIndex = 2;
            pictureBox_dot.TabStop = false;
            pictureBox_dot.Click += Click_Event;
            // 
            // label_status
            // 
            label_status.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_status.Location = new Point(59, 78);
            label_status.Margin = new Padding(4, 0, 4, 0);
            label_status.Name = "label_status";
            label_status.Size = new Size(114, 23);
            label_status.TabIndex = 3;
            label_status.Text = "Connecté";
            label_status.TextAlign = ContentAlignment.MiddleCenter;
            label_status.Click += Click_Event;
            // 
            // UserControl_PC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(label_status);
            Controls.Add(pictureBox_dot);
            Controls.Add(textBox_User);
            Controls.Add(label_PcName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControl_PC";
            Size = new Size(204, 121);
            Click += Click_Event;
            ((System.ComponentModel.ISupportInitialize)pictureBox_dot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_PcName;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.PictureBox pictureBox_dot;
        private System.Windows.Forms.Label label_status;
    }
}
