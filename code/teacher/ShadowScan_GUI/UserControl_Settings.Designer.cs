namespace ShadowScan_GUI
{
    partial class UserControl_Settings
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
            this.label_Title = new System.Windows.Forms.Label();
            this.flowLayoutPanel_SettingsList = new System.Windows.Forms.FlowLayoutPanel();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(138, 18);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(433, 73);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Settings Page";
            // 
            // flowLayoutPanel_SettingsList
            // 
            this.flowLayoutPanel_SettingsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_SettingsList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_SettingsList.Location = new System.Drawing.Point(3, 97);
            this.flowLayoutPanel_SettingsList.Name = "flowLayoutPanel_SettingsList";
            this.flowLayoutPanel_SettingsList.Size = new System.Drawing.Size(703, 308);
            this.flowLayoutPanel_SettingsList.TabIndex = 2;
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Location = new System.Drawing.Point(630, 68);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(76, 23);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Sauvegarder";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // UserControl_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.flowLayoutPanel_SettingsList);
            this.Controls.Add(this.label_Title);
            this.Name = "UserControl_Settings";
            this.Size = new System.Drawing.Size(709, 408);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_SettingsList;
        private System.Windows.Forms.Button button_save;
    }
}
