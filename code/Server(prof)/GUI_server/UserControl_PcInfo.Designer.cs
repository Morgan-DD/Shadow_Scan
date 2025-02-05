namespace GUI_server
{
    partial class UserControl_PcInfo
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
            this.textBox_IP = new System.Windows.Forms.MaskedTextBox();
            this.textbox_infos = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Status = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Username_P = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Username_Name = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Hostname = new System.Windows.Forms.TextBox();
            this.label_InfoPlus = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_IP = new System.Windows.Forms.Label();
            this.label_Hostname = new System.Windows.Forms.Label();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(12, 79);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(124, 20);
            this.textBox_IP.TabIndex = 21;
            // 
            // textbox_infos
            // 
            this.textbox_infos.Location = new System.Drawing.Point(12, 262);
            this.textbox_infos.Name = "textbox_infos";
            this.textbox_infos.Size = new System.Drawing.Size(124, 20);
            this.textbox_infos.TabIndex = 20;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(12, 209);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(124, 20);
            this.textBox_Status.TabIndex = 19;
            // 
            // textBox_Username_P
            // 
            this.textBox_Username_P.Location = new System.Drawing.Point(12, 160);
            this.textBox_Username_P.Name = "textBox_Username_P";
            this.textBox_Username_P.Size = new System.Drawing.Size(124, 20);
            this.textBox_Username_P.TabIndex = 18;
            // 
            // textBox_Username_Name
            // 
            this.textBox_Username_Name.Location = new System.Drawing.Point(12, 134);
            this.textBox_Username_Name.Name = "textBox_Username_Name";
            this.textBox_Username_Name.Size = new System.Drawing.Size(124, 20);
            this.textBox_Username_Name.TabIndex = 17;
            // 
            // textBox_Hostname
            // 
            this.textBox_Hostname.Location = new System.Drawing.Point(12, 25);
            this.textBox_Hostname.Name = "textBox_Hostname";
            this.textBox_Hostname.Size = new System.Drawing.Size(124, 20);
            this.textBox_Hostname.TabIndex = 16;
            // 
            // label_InfoPlus
            // 
            this.label_InfoPlus.AutoSize = true;
            this.label_InfoPlus.Location = new System.Drawing.Point(9, 246);
            this.label_InfoPlus.Name = "label_InfoPlus";
            this.label_InfoPlus.Size = new System.Drawing.Size(143, 13);
            this.label_InfoPlus.TabIndex = 15;
            this.label_InfoPlus.Text = "Informations supplementaires";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(9, 193);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(37, 13);
            this.label_Status.TabIndex = 14;
            this.label_Status.Text = "Status";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(9, 118);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(93, 13);
            this.label_Username.TabIndex = 13;
            this.label_Username.Text = "Info sur l\'utilisateur";
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(9, 63);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(58, 13);
            this.label_IP.TabIndex = 12;
            this.label_IP.Text = "Adresse IP";
            // 
            // label_Hostname
            // 
            this.label_Hostname.AutoSize = true;
            this.label_Hostname.Location = new System.Drawing.Point(9, 9);
            this.label_Hostname.Name = "label_Hostname";
            this.label_Hostname.Size = new System.Drawing.Size(61, 13);
            this.label_Hostname.TabIndex = 11;
            this.label_Hostname.Text = "Nom du PC";
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Close.Image = global::GUI_server.Properties.Resources.close_icon;
            this.pictureBox_Close.Location = new System.Drawing.Point(145, 3);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 22;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // UserControl_PcInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.textbox_infos);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.textBox_Username_P);
            this.Controls.Add(this.textBox_Username_Name);
            this.Controls.Add(this.textBox_Hostname);
            this.Controls.Add(this.label_InfoPlus);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.label_Hostname);
            this.Name = "UserControl_PcInfo";
            this.Size = new System.Drawing.Size(168, 304);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textBox_IP;
        private System.Windows.Forms.MaskedTextBox textbox_infos;
        private System.Windows.Forms.MaskedTextBox textBox_Status;
        private System.Windows.Forms.MaskedTextBox textBox_Username_P;
        private System.Windows.Forms.MaskedTextBox textBox_Username_Name;
        private System.Windows.Forms.TextBox textBox_Hostname;
        private System.Windows.Forms.Label label_InfoPlus;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Label label_Hostname;
        private System.Windows.Forms.PictureBox pictureBox_Close;
    }
}
