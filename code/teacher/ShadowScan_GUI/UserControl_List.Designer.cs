namespace ShadowScan_GUI
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
            label_Title = new Label();
            Panel = new FlowLayoutPanel();
            panel_rapport = new Panel();
            button_Logs = new Button();
            button_Info = new Button();
            panel_rapport_Sub = new Panel();
            panel_rapport.SuspendLayout();
            SuspendLayout();
            // 
            // label_Title
            // 
            label_Title.Anchor = AnchorStyles.Top;
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Title.Location = new Point(465, 7);
            label_Title.Margin = new Padding(4, 0, 4, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(174, 42);
            label_Title.TabIndex = 1;
            label_Title.Text = "List Page";
            // 
            // Panel
            // 
            Panel.BackColor = SystemColors.AppWorkspace;
            Panel.Location = new Point(36, 59);
            Panel.Margin = new Padding(4, 3, 4, 3);
            Panel.Name = "Panel";
            Panel.Size = new Size(702, 620);
            Panel.TabIndex = 2;
            // 
            // panel_rapport
            // 
            panel_rapport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_rapport.BackColor = SystemColors.AppWorkspace;
            panel_rapport.BorderStyle = BorderStyle.FixedSingle;
            panel_rapport.Controls.Add(button_Logs);
            panel_rapport.Controls.Add(button_Info);
            panel_rapport.Controls.Add(panel_rapport_Sub);
            panel_rapport.Location = new Point(789, 59);
            panel_rapport.Margin = new Padding(4, 3, 4, 3);
            panel_rapport.Name = "panel_rapport";
            panel_rapport.Size = new Size(343, 616);
            panel_rapport.TabIndex = 3;
            panel_rapport.Click += ButtonAction_Rapport;
            // 
            // button_Logs
            // 
            button_Logs.Location = new Point(174, 8);
            button_Logs.Margin = new Padding(4, 3, 4, 3);
            button_Logs.Name = "button_Logs";
            button_Logs.Size = new Size(88, 27);
            button_Logs.TabIndex = 2;
            button_Logs.Tag = "1";
            button_Logs.Text = "Log";
            button_Logs.UseVisualStyleBackColor = true;
            button_Logs.Click += ButtonAction_Rapport;
            // 
            // button_Info
            // 
            button_Info.Location = new Point(79, 8);
            button_Info.Margin = new Padding(4, 3, 4, 3);
            button_Info.Name = "button_Info";
            button_Info.Size = new Size(88, 27);
            button_Info.TabIndex = 1;
            button_Info.Tag = "0";
            button_Info.Text = "Informations";
            button_Info.UseVisualStyleBackColor = true;
            button_Info.Click += ButtonAction_Rapport;
            // 
            // panel_rapport_Sub
            // 
            panel_rapport_Sub.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_rapport_Sub.Location = new Point(0, 42);
            panel_rapport_Sub.Margin = new Padding(4, 3, 4, 3);
            panel_rapport_Sub.Name = "panel_rapport_Sub";
            panel_rapport_Sub.Size = new Size(343, 573);
            panel_rapport_Sub.TabIndex = 0;
            // 
            // UserControl_List
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(panel_rapport);
            Controls.Add(Panel);
            Controls.Add(label_Title);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControl_List";
            Size = new Size(1135, 678);
            panel_rapport.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Panel panel_rapport;
        private System.Windows.Forms.Panel panel_rapport_Sub;
        private System.Windows.Forms.Button button_Logs;
        private System.Windows.Forms.Button button_Info;
    }
}
