namespace ShadowScan_GUI
{
    partial class UserControl_SingleSetting
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
            this.label_SettingName = new System.Windows.Forms.Label();
            this.textBox_SettingValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_SettingName
            // 
            this.label_SettingName.AutoSize = true;
            this.label_SettingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SettingName.Location = new System.Drawing.Point(4, 6);
            this.label_SettingName.Name = "label_SettingName";
            this.label_SettingName.Size = new System.Drawing.Size(54, 20);
            this.label_SettingName.TabIndex = 0;
            this.label_SettingName.Text = "NONE";
            // 
            // textBox_SettingValue
            // 
            this.textBox_SettingValue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_SettingValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SettingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SettingValue.Location = new System.Drawing.Point(171, 3);
            this.textBox_SettingValue.Name = "textBox_SettingValue";
            this.textBox_SettingValue.Size = new System.Drawing.Size(264, 26);
            this.textBox_SettingValue.TabIndex = 1;
            this.textBox_SettingValue.TextChanged += new System.EventHandler(this.textBox_SettingValue_TextChanged);
            // 
            // UserControl_SingleSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.textBox_SettingValue);
            this.Controls.Add(this.label_SettingName);
            this.Name = "UserControl_SingleSetting";
            this.Size = new System.Drawing.Size(438, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SettingName;
        private System.Windows.Forms.TextBox textBox_SettingValue;
    }
}
