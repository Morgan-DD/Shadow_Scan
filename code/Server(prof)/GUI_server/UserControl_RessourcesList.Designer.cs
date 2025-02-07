namespace GUI_server
{
    partial class UserControl_RessourcesList
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
            this.flowLayoutPanel_MainList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_SubList = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_moveRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(284, 1);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(362, 42);
            this.label_Title.TabIndex = 4;
            this.label_Title.Text = "Liste des ressources";
            // 
            // flowLayoutPanel_MainList
            // 
            this.flowLayoutPanel_MainList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_MainList.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel_MainList.Location = new System.Drawing.Point(3, 86);
            this.flowLayoutPanel_MainList.Name = "flowLayoutPanel_MainList";
            this.flowLayoutPanel_MainList.Size = new System.Drawing.Size(390, 496);
            this.flowLayoutPanel_MainList.TabIndex = 5;
            // 
            // flowLayoutPanel_SubList
            // 
            this.flowLayoutPanel_SubList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_SubList.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel_SubList.Location = new System.Drawing.Point(537, 86);
            this.flowLayoutPanel_SubList.Name = "flowLayoutPanel_SubList";
            this.flowLayoutPanel_SubList.Size = new System.Drawing.Size(390, 496);
            this.flowLayoutPanel_SubList.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_moveRight
            // 
            this.button_moveRight.Location = new System.Drawing.Point(429, 301);
            this.button_moveRight.Name = "button_moveRight";
            this.button_moveRight.Size = new System.Drawing.Size(75, 23);
            this.button_moveRight.TabIndex = 8;
            this.button_moveRight.Text = ">>";
            this.button_moveRight.UseVisualStyleBackColor = true;
            this.button_moveRight.Click += new System.EventHandler(this.button_moveRight_Click);
            // 
            // UserControl_RessourcesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.button_moveRight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel_SubList);
            this.Controls.Add(this.flowLayoutPanel_MainList);
            this.Controls.Add(this.label_Title);
            this.Name = "UserControl_RessourcesList";
            this.Size = new System.Drawing.Size(930, 585);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_MainList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_SubList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_moveRight;
    }
}
