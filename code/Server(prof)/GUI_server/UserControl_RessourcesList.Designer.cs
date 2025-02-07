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
            this.button_moveRight = new System.Windows.Forms.Button();
            this.button_clearSubList = new System.Windows.Forms.Button();
            this.comboBox_SubList = new System.Windows.Forms.ComboBox();
            this.textBox_SubListName = new System.Windows.Forms.TextBox();
            this.label_SubListNameTitle = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_NewSubList = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel_MainList.Size = new System.Drawing.Size(390, 473);
            this.flowLayoutPanel_MainList.TabIndex = 5;
            // 
            // flowLayoutPanel_SubList
            // 
            this.flowLayoutPanel_SubList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_SubList.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel_SubList.Location = new System.Drawing.Point(537, 86);
            this.flowLayoutPanel_SubList.Name = "flowLayoutPanel_SubList";
            this.flowLayoutPanel_SubList.Size = new System.Drawing.Size(390, 467);
            this.flowLayoutPanel_SubList.TabIndex = 6;
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
            // button_clearSubList
            // 
            this.button_clearSubList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clearSubList.Location = new System.Drawing.Point(537, 559);
            this.button_clearSubList.Name = "button_clearSubList";
            this.button_clearSubList.Size = new System.Drawing.Size(75, 23);
            this.button_clearSubList.TabIndex = 9;
            this.button_clearSubList.Text = "Clear";
            this.button_clearSubList.UseVisualStyleBackColor = true;
            this.button_clearSubList.Click += new System.EventHandler(this.button_clearSubList_Click);
            // 
            // comboBox_SubList
            // 
            this.comboBox_SubList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_SubList.FormattingEnabled = true;
            this.comboBox_SubList.Location = new System.Drawing.Point(537, 59);
            this.comboBox_SubList.Name = "comboBox_SubList";
            this.comboBox_SubList.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SubList.TabIndex = 11;
            this.comboBox_SubList.SelectedIndexChanged += new System.EventHandler(this.comboBox_SubList_SelectedIndexChanged);
            // 
            // textBox_SubListName
            // 
            this.textBox_SubListName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SubListName.Enabled = false;
            this.textBox_SubListName.Location = new System.Drawing.Point(770, 60);
            this.textBox_SubListName.Name = "textBox_SubListName";
            this.textBox_SubListName.Size = new System.Drawing.Size(157, 20);
            this.textBox_SubListName.TabIndex = 12;
            this.textBox_SubListName.TextChanged += new System.EventHandler(this.textBox_SubListName_TextChanged);
            // 
            // label_SubListNameTitle
            // 
            this.label_SubListNameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SubListNameTitle.AutoSize = true;
            this.label_SubListNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SubListNameTitle.Location = new System.Drawing.Point(661, 60);
            this.label_SubListNameTitle.Name = "label_SubListNameTitle";
            this.label_SubListNameTitle.Size = new System.Drawing.Size(106, 18);
            this.label_SubListNameTitle.TabIndex = 13;
            this.label_SubListNameTitle.Text = "Nom de la liste";
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Location = new System.Drawing.Point(618, 559);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "Enrgistrer";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_NewSubList
            // 
            this.button_NewSubList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NewSubList.Enabled = false;
            this.button_NewSubList.Location = new System.Drawing.Point(699, 559);
            this.button_NewSubList.Name = "button_NewSubList";
            this.button_NewSubList.Size = new System.Drawing.Size(75, 23);
            this.button_NewSubList.TabIndex = 15;
            this.button_NewSubList.Text = "Nouvelle";
            this.button_NewSubList.UseVisualStyleBackColor = true;
            this.button_NewSubList.Click += new System.EventHandler(this.button_NewSubList_Click);
            // 
            // UserControl_RessourcesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.button_NewSubList);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_SubListNameTitle);
            this.Controls.Add(this.textBox_SubListName);
            this.Controls.Add(this.comboBox_SubList);
            this.Controls.Add(this.button_clearSubList);
            this.Controls.Add(this.button_moveRight);
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
        private System.Windows.Forms.Button button_moveRight;
        private System.Windows.Forms.Button button_clearSubList;
        private System.Windows.Forms.ComboBox comboBox_SubList;
        private System.Windows.Forms.TextBox textBox_SubListName;
        private System.Windows.Forms.Label label_SubListNameTitle;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_NewSubList;
    }
}
