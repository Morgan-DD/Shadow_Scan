namespace ShadowScan_GUI
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
            Button_Main = new Button();
            button_list = new Button();
            button_settings = new Button();
            pictureBox1 = new PictureBox();
            panel_main = new Panel();
            panel_top = new Panel();
            pictureBox_Minimize = new PictureBox();
            pictureBox_Maximize = new PictureBox();
            pictureBox_Close = new PictureBox();
            Button_Test = new Button();
            button_RessourceList = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Close).BeginInit();
            SuspendLayout();
            // 
            // Button_Main
            // 
            Button_Main.Location = new Point(14, 40);
            Button_Main.Margin = new Padding(4, 3, 4, 3);
            Button_Main.Name = "Button_Main";
            Button_Main.Size = new Size(88, 27);
            Button_Main.TabIndex = 0;
            Button_Main.Tag = "0";
            Button_Main.Text = "Scan";
            Button_Main.UseVisualStyleBackColor = true;
            Button_Main.Click += Button_MenuClick;
            // 
            // button_list
            // 
            button_list.Location = new Point(108, 40);
            button_list.Margin = new Padding(4, 3, 4, 3);
            button_list.Name = "button_list";
            button_list.Size = new Size(88, 27);
            button_list.TabIndex = 2;
            button_list.Tag = "1";
            button_list.Text = "List";
            button_list.UseVisualStyleBackColor = true;
            button_list.Click += Button_MenuClick;
            // 
            // button_settings
            // 
            button_settings.Location = new Point(203, 40);
            button_settings.Margin = new Padding(4, 3, 4, 3);
            button_settings.Name = "button_settings";
            button_settings.Size = new Size(88, 27);
            button_settings.TabIndex = 3;
            button_settings.Tag = "2";
            button_settings.Text = "Settings";
            button_settings.UseVisualStyleBackColor = true;
            button_settings.Click += Button_MenuClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.ShadowScan_logo;
            pictureBox1.Location = new Point(1040, 37);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // panel_main
            // 
            panel_main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_main.BackColor = SystemColors.ActiveBorder;
            panel_main.Location = new Point(4, 84);
            panel_main.Margin = new Padding(4, 3, 4, 3);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1077, 587);
            panel_main.TabIndex = 5;
            // 
            // panel_top
            // 
            panel_top.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_top.BackColor = SystemColors.InactiveCaption;
            panel_top.Controls.Add(pictureBox_Minimize);
            panel_top.Controls.Add(pictureBox_Maximize);
            panel_top.Controls.Add(pictureBox_Close);
            panel_top.Location = new Point(0, 0);
            panel_top.Margin = new Padding(4, 3, 4, 3);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1085, 30);
            panel_top.TabIndex = 6;
            panel_top.MouseDown += OnMouseDown;
            // 
            // pictureBox_Minimize
            // 
            pictureBox_Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox_Minimize.BackColor = Color.Transparent;
            pictureBox_Minimize.Image = Properties.Resources.hide_icon;
            pictureBox_Minimize.Location = new Point(996, 3);
            pictureBox_Minimize.Margin = new Padding(4, 3, 4, 3);
            pictureBox_Minimize.Name = "pictureBox_Minimize";
            pictureBox_Minimize.Size = new Size(23, 23);
            pictureBox_Minimize.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Minimize.TabIndex = 2;
            pictureBox_Minimize.TabStop = false;
            pictureBox_Minimize.Click += pictureBox_Minimize_Click;
            pictureBox_Minimize.MouseEnter += pictureBox_Enter;
            pictureBox_Minimize.MouseLeave += pictureBox_Leave;
            // 
            // pictureBox_Maximize
            // 
            pictureBox_Maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox_Maximize.BackColor = Color.Transparent;
            pictureBox_Maximize.Image = Properties.Resources.expand_icon;
            pictureBox_Maximize.Location = new Point(1027, 3);
            pictureBox_Maximize.Margin = new Padding(4, 3, 4, 3);
            pictureBox_Maximize.Name = "pictureBox_Maximize";
            pictureBox_Maximize.Size = new Size(23, 23);
            pictureBox_Maximize.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Maximize.TabIndex = 1;
            pictureBox_Maximize.TabStop = false;
            pictureBox_Maximize.Click += pictureBox_Maximize_Click;
            pictureBox_Maximize.MouseEnter += pictureBox_Enter;
            pictureBox_Maximize.MouseLeave += pictureBox_Leave;
            // 
            // pictureBox_Close
            // 
            pictureBox_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox_Close.BackColor = Color.Transparent;
            pictureBox_Close.Image = Properties.Resources.close_icon;
            pictureBox_Close.Location = new Point(1057, 3);
            pictureBox_Close.Margin = new Padding(4, 3, 4, 3);
            pictureBox_Close.Name = "pictureBox_Close";
            pictureBox_Close.Size = new Size(23, 23);
            pictureBox_Close.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Close.TabIndex = 0;
            pictureBox_Close.TabStop = false;
            pictureBox_Close.Click += pictureBox_Close_Click;
            pictureBox_Close.MouseEnter += pictureBox_Enter;
            pictureBox_Close.MouseLeave += pictureBox_Leave;
            // 
            // Button_Test
            // 
            Button_Test.Location = new Point(864, 40);
            Button_Test.Margin = new Padding(4, 3, 4, 3);
            Button_Test.Name = "Button_Test";
            Button_Test.Size = new Size(88, 27);
            Button_Test.TabIndex = 7;
            Button_Test.Text = "Test";
            Button_Test.UseVisualStyleBackColor = true;
            Button_Test.Click += Button_Test_Click;
            // 
            // button_RessourceList
            // 
            button_RessourceList.Location = new Point(298, 40);
            button_RessourceList.Margin = new Padding(4, 3, 4, 3);
            button_RessourceList.Name = "button_RessourceList";
            button_RessourceList.Size = new Size(140, 27);
            button_RessourceList.TabIndex = 10;
            button_RessourceList.Tag = "4";
            button_RessourceList.Text = "Liste des Ressources";
            button_RessourceList.UseVisualStyleBackColor = true;
            button_RessourceList.Click += Button_MenuClick;
            // 
            // Form_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1085, 675);
            Controls.Add(button_RessourceList);
            Controls.Add(Button_Test);
            Controls.Add(panel_top);
            Controls.Add(panel_main);
            Controls.Add(pictureBox1);
            Controls.Add(button_settings);
            Controls.Add(button_list);
            Controls.Add(Button_Main);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1085, 675);
            Name = "Form_main";
            Text = "ShadowScan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Close).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.Button button_RessourceList;
    }
}

