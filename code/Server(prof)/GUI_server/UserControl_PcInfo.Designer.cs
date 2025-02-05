namespace GUI_server
{
    partial class textBox_InfoPlus
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
            this.label_Hostname = new System.Windows.Forms.Label();
            this.label_IP = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_InfoPlus = new System.Windows.Forms.Label();
            this.textBox_Hostname = new System.Windows.Forms.TextBox();
            this.textBox_Username_Name = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Username_P = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Status = new System.Windows.Forms.MaskedTextBox();
            this.textbox_infos = new System.Windows.Forms.MaskedTextBox();
            this.textBox_IP = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label_Hostname
            // 
            this.label_Hostname.AutoSize = true;
            this.label_Hostname.Location = new System.Drawing.Point(13, 17);
            this.label_Hostname.Name = "label_Hostname";
            this.label_Hostname.Size = new System.Drawing.Size(61, 13);
            this.label_Hostname.TabIndex = 0;
            this.label_Hostname.Text = "Nom du PC";
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(13, 71);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(58, 13);
            this.label_IP.TabIndex = 1;
            this.label_IP.Text = "Adresse IP";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(13, 126);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(93, 13);
            this.label_Username.TabIndex = 2;
            this.label_Username.Text = "Info sur l\'utilisateur";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(13, 201);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(37, 13);
            this.label_Status.TabIndex = 3;
            this.label_Status.Text = "Status";
            // 
            // label_InfoPlus
            // 
            this.label_InfoPlus.AutoSize = true;
            this.label_InfoPlus.Location = new System.Drawing.Point(13, 254);
            this.label_InfoPlus.Name = "label_InfoPlus";
            this.label_InfoPlus.Size = new System.Drawing.Size(143, 13);
            this.label_InfoPlus.TabIndex = 4;
            this.label_InfoPlus.Text = "Informations supplementaires";
            // 
            // textBox_Hostname
            // 
            this.textBox_Hostname.Location = new System.Drawing.Point(16, 33);
            this.textBox_Hostname.Name = "textBox_Hostname";
            this.textBox_Hostname.Size = new System.Drawing.Size(124, 20);
            this.textBox_Hostname.TabIndex = 5;
            // 
            // textBox_Username_Name
            // 
            this.textBox_Username_Name.Location = new System.Drawing.Point(16, 142);
            this.textBox_Username_Name.Name = "textBox_Username_Name";
            this.textBox_Username_Name.Size = new System.Drawing.Size(124, 20);
            this.textBox_Username_Name.TabIndex = 6;
            // 
            // textBox_Username_P
            // 
            this.textBox_Username_P.Location = new System.Drawing.Point(16, 168);
            this.textBox_Username_P.Name = "textBox_Username_P";
            this.textBox_Username_P.Size = new System.Drawing.Size(124, 20);
            this.textBox_Username_P.TabIndex = 7;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(16, 217);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(124, 20);
            this.textBox_Status.TabIndex = 8;
            // 
            // textbox_infos
            // 
            this.textbox_infos.Location = new System.Drawing.Point(16, 270);
            this.textbox_infos.Name = "textbox_infos";
            this.textbox_infos.Size = new System.Drawing.Size(124, 20);
            this.textbox_infos.TabIndex = 9;
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(16, 87);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(124, 20);
            this.textBox_IP.TabIndex = 10;
            // 
            // textBox_InfoPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "textBox_InfoPlus";
            this.Size = new System.Drawing.Size(201, 341);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Hostname;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_InfoPlus;
        private System.Windows.Forms.TextBox textBox_Hostname;
        private System.Windows.Forms.MaskedTextBox textBox_Username_Name;
        private System.Windows.Forms.MaskedTextBox textBox_Username_P;
        private System.Windows.Forms.MaskedTextBox textBox_Status;
        private System.Windows.Forms.MaskedTextBox textbox_infos;
        private System.Windows.Forms.MaskedTextBox textBox_IP;
    }
}
