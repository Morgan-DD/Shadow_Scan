namespace GUI_server
{
    partial class Form_main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.Button_Main = new System.Windows.Forms.Button();
            this.button_list = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.Button_Test = new System.Windows.Forms.Button();
            this.label_size = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Main
            // 
            this.Button_Main.Location = new System.Drawing.Point(12, 35);
            this.Button_Main.Name = "Button_Main";
            this.Button_Main.Size = new System.Drawing.Size(75, 23);
            this.Button_Main.TabIndex = 0;
            this.Button_Main.Tag = "0";
            this.Button_Main.Text = "Scan";
            this.Button_Main.UseVisualStyleBackColor = true;
            this.Button_Main.Click += new System.EventHandler(this.Button_MenuClick);
            // 
            // button_list
            // 
            this.button_list.Location = new System.Drawing.Point(93, 35);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(75, 23);
            this.button_list.TabIndex = 2;
            this.button_list.Tag = "1";
            this.button_list.Text = "List";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.Button_MenuClick);
            // 
            // button_settings
            // 
            this.button_settings.Location = new System.Drawing.Point(174, 35);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(75, 23);
            this.button_settings.TabIndex = 3;
            this.button_settings.Tag = "2";
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.Button_MenuClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::GUI_server.Properties.Resources.ShadowScan_logo;
            this.pictureBox1.Location = new System.Drawing.Point(840, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_main.Location = new System.Drawing.Point(3, 73);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(872, 524);
            this.panel_main.TabIndex = 5;
            // 
            // panel_top
            // 
            this.panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_top.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel_top.Controls.Add(this.pictureBox_Minimize);
            this.panel_top.Controls.Add(this.pictureBox_Maximize);
            this.panel_top.Controls.Add(this.pictureBox_Close);
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(879, 26);
            this.panel_top.TabIndex = 6;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Minimize.Image = global::GUI_server.Properties.Resources.hide_icon;
            this.pictureBox_Minimize.Location = new System.Drawing.Point(803, 3);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Minimize.TabIndex = 2;
            this.pictureBox_Minimize.TabStop = false;
            this.pictureBox_Minimize.Click += new System.EventHandler(this.pictureBox_Minimize_Click);
            this.pictureBox_Minimize.MouseEnter += new System.EventHandler(this.pictureBox_Enter);
            this.pictureBox_Minimize.MouseLeave += new System.EventHandler(this.pictureBox_Leave);
            // 
            // pictureBox_Maximize
            // 
            this.pictureBox_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Maximize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Maximize.Image")));
            this.pictureBox_Maximize.Location = new System.Drawing.Point(829, 3);
            this.pictureBox_Maximize.Name = "pictureBox_Maximize";
            this.pictureBox_Maximize.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Maximize.TabIndex = 1;
            this.pictureBox_Maximize.TabStop = false;
            this.pictureBox_Maximize.Click += new System.EventHandler(this.pictureBox_Maximize_Click);
            this.pictureBox_Maximize.MouseEnter += new System.EventHandler(this.pictureBox_Enter);
            this.pictureBox_Maximize.MouseLeave += new System.EventHandler(this.pictureBox_Leave);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Close.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Close.Image = global::GUI_server.Properties.Resources.close_icon;
            this.pictureBox_Close.Location = new System.Drawing.Point(855, 3);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 0;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Close.MouseEnter += new System.EventHandler(this.pictureBox_Enter);
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Leave);
            // 
            // Button_Test
            // 
            this.Button_Test.Location = new System.Drawing.Point(408, 43);
            this.Button_Test.Name = "Button_Test";
            this.Button_Test.Size = new System.Drawing.Size(75, 23);
            this.Button_Test.TabIndex = 7;
            this.Button_Test.Text = "Test";
            this.Button_Test.UseVisualStyleBackColor = true;
            this.Button_Test.Click += new System.EventHandler(this.Button_Test_Click);
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(489, 45);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(28, 13);
            this.label_size.TabIndex = 8;
            this.label_size.Text = "AAA";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(879, 600);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.Button_Test);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_list);
            this.Controls.Add(this.Button_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(879, 600);
            this.Name = "Form_main";
            this.Text = "ShadowScan";
            this.Resize += new System.EventHandler(this.Form_main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Main;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private System.Windows.Forms.PictureBox pictureBox_Maximize;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Button Button_Test;
        private System.Windows.Forms.Label label_size;
    }
}

