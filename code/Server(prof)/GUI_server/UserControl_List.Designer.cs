namespace GUI_server
{
    partial class UserControl_List
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
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_rapport = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button_Logs = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.panel_rapport_Sub = new System.Windows.Forms.Panel();
            this.panel_rapport.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(399, 6);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(174, 42);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "List Page";
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel.Location = new System.Drawing.Point(0, 51);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(690, 537);
            this.Panel.TabIndex = 2;
            // 
            // panel_rapport
            // 
            this.panel_rapport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_rapport.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_rapport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_rapport.Controls.Add(this.button3);
            this.panel_rapport.Controls.Add(this.button_Logs);
            this.panel_rapport.Controls.Add(this.button_Info);
            this.panel_rapport.Controls.Add(this.panel_rapport_Sub);
            this.panel_rapport.Location = new System.Drawing.Point(676, 51);
            this.panel_rapport.Name = "panel_rapport";
            this.panel_rapport.Size = new System.Drawing.Size(294, 534);
            this.panel_rapport.TabIndex = 3;
            this.panel_rapport.Click += new System.EventHandler(this.ButtonAction_Rapport);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Tag = "2";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonAction_Rapport);
            // 
            // button_Logs
            // 
            this.button_Logs.Location = new System.Drawing.Point(84, 7);
            this.button_Logs.Name = "button_Logs";
            this.button_Logs.Size = new System.Drawing.Size(75, 23);
            this.button_Logs.TabIndex = 2;
            this.button_Logs.Tag = "1";
            this.button_Logs.Text = "Log";
            this.button_Logs.UseVisualStyleBackColor = true;
            this.button_Logs.Click += new System.EventHandler(this.ButtonAction_Rapport);
            // 
            // button_Info
            // 
            this.button_Info.Location = new System.Drawing.Point(3, 7);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(75, 23);
            this.button_Info.TabIndex = 1;
            this.button_Info.Tag = "0";
            this.button_Info.Text = "Informations";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.ButtonAction_Rapport);
            // 
            // panel_rapport_Sub
            // 
            this.panel_rapport_Sub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_rapport_Sub.Location = new System.Drawing.Point(0, 36);
            this.panel_rapport_Sub.Name = "panel_rapport_Sub";
            this.panel_rapport_Sub.Size = new System.Drawing.Size(294, 497);
            this.panel_rapport_Sub.TabIndex = 0;
            // 
            // UserControl_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel_rapport);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label_Title);
            this.Name = "UserControl_List";
            this.Size = new System.Drawing.Size(973, 588);
            this.panel_rapport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Panel panel_rapport;
        private System.Windows.Forms.Panel panel_rapport_Sub;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_Logs;
        private System.Windows.Forms.Button button_Info;
    }
}
