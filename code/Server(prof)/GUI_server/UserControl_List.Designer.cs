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
            this.panel_rapport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_rapport.Location = new System.Drawing.Point(676, 51);
            this.panel_rapport.Name = "panel_rapport";
            this.panel_rapport.Size = new System.Drawing.Size(294, 534);
            this.panel_rapport.TabIndex = 3;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Panel panel_rapport;
    }
}
