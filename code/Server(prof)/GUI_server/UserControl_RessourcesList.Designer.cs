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
            this.comboBox_SubList = new System.Windows.Forms.ComboBox();
            this.textBox_SubListName = new System.Windows.Forms.TextBox();
            this.label_SubListNameTitle = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_NewSubList = new System.Windows.Forms.Button();
            this.button_removeSubList = new System.Windows.Forms.Button();
            this.button_DeletSubList = new System.Windows.Forms.Button();
            this.textBox_addMainList = new System.Windows.Forms.TextBox();
            this.button_addToMainList = new System.Windows.Forms.Button();
            this.comboBox_addMainList = new System.Windows.Forms.ComboBox();
            this.button_ExportMain = new System.Windows.Forms.Button();
            this.button_ExportSubList_All = new System.Windows.Forms.Button();
            this.label_Export = new System.Windows.Forms.Label();
            this.button_ExportSubList_Single = new System.Windows.Forms.Button();
            this.button_DeletFromMainList = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel_MainList.Size = new System.Drawing.Size(390, 467);
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
            this.textBox_SubListName.Location = new System.Drawing.Point(770, 60);
            this.textBox_SubListName.Name = "textBox_SubListName";
            this.textBox_SubListName.Size = new System.Drawing.Size(157, 20);
            this.textBox_SubListName.TabIndex = 12;
            this.textBox_SubListName.TextChanged += new System.EventHandler(this.textBox_SubListName_TextChanged);
            this.textBox_SubListName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_SubListName_KeyDown);
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
            this.button_save.Location = new System.Drawing.Point(537, 559);
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
            this.button_NewSubList.Location = new System.Drawing.Point(618, 559);
            this.button_NewSubList.Name = "button_NewSubList";
            this.button_NewSubList.Size = new System.Drawing.Size(75, 23);
            this.button_NewSubList.TabIndex = 15;
            this.button_NewSubList.Text = "Nouvelle";
            this.button_NewSubList.UseVisualStyleBackColor = true;
            this.button_NewSubList.Click += new System.EventHandler(this.button_NewSubList_Click);
            // 
            // button_removeSubList
            // 
            this.button_removeSubList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_removeSubList.Location = new System.Drawing.Point(699, 559);
            this.button_removeSubList.Name = "button_removeSubList";
            this.button_removeSubList.Size = new System.Drawing.Size(66, 23);
            this.button_removeSubList.TabIndex = 17;
            this.button_removeSubList.Text = "Supprimer";
            this.button_removeSubList.UseVisualStyleBackColor = true;
            this.button_removeSubList.Click += new System.EventHandler(this.button_removeSubList_Click);
            // 
            // button_DeletSubList
            // 
            this.button_DeletSubList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeletSubList.Location = new System.Drawing.Point(770, 559);
            this.button_DeletSubList.Name = "button_DeletSubList";
            this.button_DeletSubList.Size = new System.Drawing.Size(100, 23);
            this.button_DeletSubList.TabIndex = 18;
            this.button_DeletSubList.Text = "Supprimer la liste";
            this.button_DeletSubList.UseVisualStyleBackColor = true;
            this.button_DeletSubList.Click += new System.EventHandler(this.button_DeletSubList_Click);
            // 
            // textBox_addMainList
            // 
            this.textBox_addMainList.Location = new System.Drawing.Point(3, 62);
            this.textBox_addMainList.Name = "textBox_addMainList";
            this.textBox_addMainList.Size = new System.Drawing.Size(183, 20);
            this.textBox_addMainList.TabIndex = 19;
            this.textBox_addMainList.TextChanged += new System.EventHandler(this.textBox_addMainList_TextChanged);
            // 
            // button_addToMainList
            // 
            this.button_addToMainList.Enabled = false;
            this.button_addToMainList.Location = new System.Drawing.Point(318, 60);
            this.button_addToMainList.Name = "button_addToMainList";
            this.button_addToMainList.Size = new System.Drawing.Size(75, 23);
            this.button_addToMainList.TabIndex = 20;
            this.button_addToMainList.Text = "Ajouter";
            this.button_addToMainList.UseVisualStyleBackColor = true;
            this.button_addToMainList.Click += new System.EventHandler(this.button_addToMainList_Click);
            // 
            // comboBox_addMainList
            // 
            this.comboBox_addMainList.FormattingEnabled = true;
            this.comboBox_addMainList.Location = new System.Drawing.Point(192, 61);
            this.comboBox_addMainList.Name = "comboBox_addMainList";
            this.comboBox_addMainList.Size = new System.Drawing.Size(121, 21);
            this.comboBox_addMainList.TabIndex = 21;
            this.comboBox_addMainList.SelectedIndexChanged += new System.EventHandler(this.comboBox_addMainList_SelectedIndexChanged);
            // 
            // button_ExportMain
            // 
            this.button_ExportMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ExportMain.Location = new System.Drawing.Point(413, 442);
            this.button_ExportMain.Name = "button_ExportMain";
            this.button_ExportMain.Size = new System.Drawing.Size(102, 23);
            this.button_ExportMain.TabIndex = 22;
            this.button_ExportMain.Tag = "0";
            this.button_ExportMain.Text = "Liste principale";
            this.button_ExportMain.UseVisualStyleBackColor = true;
            this.button_ExportMain.Click += new System.EventHandler(this.exportButtonAction);
            // 
            // button_ExportSubList_All
            // 
            this.button_ExportSubList_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ExportSubList_All.Location = new System.Drawing.Point(413, 471);
            this.button_ExportSubList_All.Name = "button_ExportSubList_All";
            this.button_ExportSubList_All.Size = new System.Drawing.Size(102, 39);
            this.button_ExportSubList_All.TabIndex = 23;
            this.button_ExportSubList_All.Tag = "1";
            this.button_ExportSubList_All.Text = "Liste Secondaire Complete";
            this.button_ExportSubList_All.UseVisualStyleBackColor = true;
            this.button_ExportSubList_All.Click += new System.EventHandler(this.exportButtonAction);
            // 
            // label_Export
            // 
            this.label_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Export.AutoSize = true;
            this.label_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Export.Location = new System.Drawing.Point(405, 411);
            this.label_Export.Name = "label_Export";
            this.label_Export.Size = new System.Drawing.Size(121, 25);
            this.label_Export.TabIndex = 24;
            this.label_Export.Text = "Exportation";
            // 
            // button_ExportSubList_Single
            // 
            this.button_ExportSubList_Single.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ExportSubList_Single.Location = new System.Drawing.Point(413, 516);
            this.button_ExportSubList_Single.Name = "button_ExportSubList_Single";
            this.button_ExportSubList_Single.Size = new System.Drawing.Size(102, 39);
            this.button_ExportSubList_Single.TabIndex = 25;
            this.button_ExportSubList_Single.Tag = "1";
            this.button_ExportSubList_Single.Text = "Liste Secondaire actuelle";
            this.button_ExportSubList_Single.UseVisualStyleBackColor = true;
            this.button_ExportSubList_Single.Click += new System.EventHandler(this.exportButtonAction);
            // 
            // button_DeletFromMainList
            // 
            this.button_DeletFromMainList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_DeletFromMainList.Location = new System.Drawing.Point(3, 559);
            this.button_DeletFromMainList.Name = "button_DeletFromMainList";
            this.button_DeletFromMainList.Size = new System.Drawing.Size(390, 23);
            this.button_DeletFromMainList.TabIndex = 26;
            this.button_DeletFromMainList.Text = "Delete";
            this.button_DeletFromMainList.UseVisualStyleBackColor = true;
            this.button_DeletFromMainList.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UserControl_RessourcesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.button_DeletFromMainList);
            this.Controls.Add(this.button_ExportSubList_Single);
            this.Controls.Add(this.label_Export);
            this.Controls.Add(this.button_ExportSubList_All);
            this.Controls.Add(this.button_ExportMain);
            this.Controls.Add(this.comboBox_addMainList);
            this.Controls.Add(this.button_addToMainList);
            this.Controls.Add(this.textBox_addMainList);
            this.Controls.Add(this.button_DeletSubList);
            this.Controls.Add(this.button_removeSubList);
            this.Controls.Add(this.button_NewSubList);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_SubListNameTitle);
            this.Controls.Add(this.textBox_SubListName);
            this.Controls.Add(this.comboBox_SubList);
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
        private System.Windows.Forms.ComboBox comboBox_SubList;
        private System.Windows.Forms.TextBox textBox_SubListName;
        private System.Windows.Forms.Label label_SubListNameTitle;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_NewSubList;
        private System.Windows.Forms.Button button_removeSubList;
        private System.Windows.Forms.Button button_DeletSubList;
        private System.Windows.Forms.TextBox textBox_addMainList;
        private System.Windows.Forms.Button button_addToMainList;
        private System.Windows.Forms.ComboBox comboBox_addMainList;
        private System.Windows.Forms.Button button_ExportMain;
        private System.Windows.Forms.Button button_ExportSubList_All;
        private System.Windows.Forms.Label label_Export;
        private System.Windows.Forms.Button button_ExportSubList_Single;
        private System.Windows.Forms.Button button_DeletFromMainList;
    }
}
