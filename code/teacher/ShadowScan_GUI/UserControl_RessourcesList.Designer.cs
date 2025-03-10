namespace ShadowScan_GUI
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
            label_Title = new Label();
            flowLayoutPanel_MainList = new FlowLayoutPanel();
            flowLayoutPanel_SubList = new FlowLayoutPanel();
            button_moveRight = new Button();
            comboBox_SubList = new ComboBox();
            textBox_SubListName = new TextBox();
            label_SubListNameTitle = new Label();
            button_save = new Button();
            button_NewSubList = new Button();
            button_removeSubList = new Button();
            button_DeletSubList = new Button();
            textBox_addMainList = new TextBox();
            button_addToMainList = new Button();
            comboBox_addMainList = new ComboBox();
            button_ExportMain = new Button();
            button_ExportSubList_All = new Button();
            label_Export = new Label();
            button_ExportSubList_Single = new Button();
            button_DeletFromMainList = new Button();
            SuspendLayout();
            // 
            // label_Title
            // 
            label_Title.Anchor = AnchorStyles.Top;
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Title.Location = new Point(331, 1);
            label_Title.Margin = new Padding(4, 0, 4, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(362, 42);
            label_Title.TabIndex = 4;
            label_Title.Text = "Liste des ressources";
            // 
            // flowLayoutPanel_MainList
            // 
            flowLayoutPanel_MainList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel_MainList.BackColor = SystemColors.ButtonShadow;
            flowLayoutPanel_MainList.Location = new Point(4, 99);
            flowLayoutPanel_MainList.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel_MainList.Name = "flowLayoutPanel_MainList";
            flowLayoutPanel_MainList.Size = new Size(455, 539);
            flowLayoutPanel_MainList.TabIndex = 5;
            // 
            // flowLayoutPanel_SubList
            // 
            flowLayoutPanel_SubList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel_SubList.BackColor = SystemColors.ButtonShadow;
            flowLayoutPanel_SubList.Location = new Point(626, 99);
            flowLayoutPanel_SubList.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel_SubList.Name = "flowLayoutPanel_SubList";
            flowLayoutPanel_SubList.Size = new Size(455, 539);
            flowLayoutPanel_SubList.TabIndex = 6;
            // 
            // button_moveRight
            // 
            button_moveRight.Location = new Point(500, 347);
            button_moveRight.Margin = new Padding(4, 3, 4, 3);
            button_moveRight.Name = "button_moveRight";
            button_moveRight.Size = new Size(88, 27);
            button_moveRight.TabIndex = 8;
            button_moveRight.Text = ">>";
            button_moveRight.UseVisualStyleBackColor = true;
            button_moveRight.Click += button_moveRight_Click;
            // 
            // comboBox_SubList
            // 
            comboBox_SubList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_SubList.FormattingEnabled = true;
            comboBox_SubList.Location = new Point(626, 68);
            comboBox_SubList.Margin = new Padding(4, 3, 4, 3);
            comboBox_SubList.Name = "comboBox_SubList";
            comboBox_SubList.Size = new Size(140, 23);
            comboBox_SubList.TabIndex = 11;
            comboBox_SubList.SelectedIndexChanged += comboBox_SubList_SelectedIndexChanged;
            // 
            // textBox_SubListName
            // 
            textBox_SubListName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_SubListName.Location = new Point(898, 69);
            textBox_SubListName.Margin = new Padding(4, 3, 4, 3);
            textBox_SubListName.Name = "textBox_SubListName";
            textBox_SubListName.Size = new Size(182, 23);
            textBox_SubListName.TabIndex = 12;
            textBox_SubListName.TextChanged += textBox_SubListName_TextChanged;
            textBox_SubListName.KeyDown += textBox_SubListName_KeyDown;
            // 
            // label_SubListNameTitle
            // 
            label_SubListNameTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_SubListNameTitle.AutoSize = true;
            label_SubListNameTitle.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_SubListNameTitle.Location = new Point(771, 69);
            label_SubListNameTitle.Margin = new Padding(4, 0, 4, 0);
            label_SubListNameTitle.Name = "label_SubListNameTitle";
            label_SubListNameTitle.Size = new Size(106, 18);
            label_SubListNameTitle.TabIndex = 13;
            label_SubListNameTitle.Text = "Nom de la liste";
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_save.Location = new Point(626, 645);
            button_save.Margin = new Padding(4, 3, 4, 3);
            button_save.Name = "button_save";
            button_save.Size = new Size(88, 27);
            button_save.TabIndex = 14;
            button_save.Text = "Enregistrer";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_NewSubList
            // 
            button_NewSubList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_NewSubList.Enabled = false;
            button_NewSubList.Location = new Point(721, 645);
            button_NewSubList.Margin = new Padding(4, 3, 4, 3);
            button_NewSubList.Name = "button_NewSubList";
            button_NewSubList.Size = new Size(88, 27);
            button_NewSubList.TabIndex = 15;
            button_NewSubList.Text = "Nouvelle";
            button_NewSubList.UseVisualStyleBackColor = true;
            button_NewSubList.Click += button_NewSubList_Click;
            // 
            // button_removeSubList
            // 
            button_removeSubList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_removeSubList.Location = new Point(816, 645);
            button_removeSubList.Margin = new Padding(4, 3, 4, 3);
            button_removeSubList.Name = "button_removeSubList";
            button_removeSubList.Size = new Size(77, 27);
            button_removeSubList.TabIndex = 17;
            button_removeSubList.Text = "Supprimer";
            button_removeSubList.UseVisualStyleBackColor = true;
            button_removeSubList.Click += button_removeSubList_Click;
            // 
            // button_DeletSubList
            // 
            button_DeletSubList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_DeletSubList.Location = new Point(898, 645);
            button_DeletSubList.Margin = new Padding(4, 3, 4, 3);
            button_DeletSubList.Name = "button_DeletSubList";
            button_DeletSubList.Size = new Size(117, 27);
            button_DeletSubList.TabIndex = 18;
            button_DeletSubList.Text = "Supprimer la liste";
            button_DeletSubList.UseVisualStyleBackColor = true;
            button_DeletSubList.Click += button_DeletSubList_Click;
            // 
            // textBox_addMainList
            // 
            textBox_addMainList.Location = new Point(4, 72);
            textBox_addMainList.Margin = new Padding(4, 3, 4, 3);
            textBox_addMainList.Name = "textBox_addMainList";
            textBox_addMainList.Size = new Size(213, 23);
            textBox_addMainList.TabIndex = 19;
            textBox_addMainList.TextChanged += textBox_addMainList_TextChanged;
            // 
            // button_addToMainList
            // 
            button_addToMainList.Enabled = false;
            button_addToMainList.Location = new Point(371, 69);
            button_addToMainList.Margin = new Padding(4, 3, 4, 3);
            button_addToMainList.Name = "button_addToMainList";
            button_addToMainList.Size = new Size(88, 27);
            button_addToMainList.TabIndex = 20;
            button_addToMainList.Text = "Ajouter";
            button_addToMainList.UseVisualStyleBackColor = true;
            button_addToMainList.Click += button_addToMainList_Click;
            // 
            // comboBox_addMainList
            // 
            comboBox_addMainList.FormattingEnabled = true;
            comboBox_addMainList.Location = new Point(224, 70);
            comboBox_addMainList.Margin = new Padding(4, 3, 4, 3);
            comboBox_addMainList.Name = "comboBox_addMainList";
            comboBox_addMainList.Size = new Size(140, 23);
            comboBox_addMainList.TabIndex = 21;
            comboBox_addMainList.SelectedIndexChanged += comboBox_addMainList_SelectedIndexChanged;
            // 
            // button_ExportMain
            // 
            button_ExportMain.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_ExportMain.Location = new Point(482, 510);
            button_ExportMain.Margin = new Padding(4, 3, 4, 3);
            button_ExportMain.Name = "button_ExportMain";
            button_ExportMain.Size = new Size(119, 27);
            button_ExportMain.TabIndex = 22;
            button_ExportMain.Tag = "0";
            button_ExportMain.Text = "Liste principale";
            button_ExportMain.UseVisualStyleBackColor = true;
            button_ExportMain.Click += exportButtonAction;
            // 
            // button_ExportSubList_All
            // 
            button_ExportSubList_All.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_ExportSubList_All.Location = new Point(482, 543);
            button_ExportSubList_All.Margin = new Padding(4, 3, 4, 3);
            button_ExportSubList_All.Name = "button_ExportSubList_All";
            button_ExportSubList_All.Size = new Size(119, 45);
            button_ExportSubList_All.TabIndex = 23;
            button_ExportSubList_All.Tag = "1";
            button_ExportSubList_All.Text = "Liste Secondaire Complete";
            button_ExportSubList_All.UseVisualStyleBackColor = true;
            button_ExportSubList_All.Click += exportButtonAction;
            // 
            // label_Export
            // 
            label_Export.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_Export.AutoSize = true;
            label_Export.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Export.Location = new Point(472, 474);
            label_Export.Margin = new Padding(4, 0, 4, 0);
            label_Export.Name = "label_Export";
            label_Export.Size = new Size(121, 25);
            label_Export.TabIndex = 24;
            label_Export.Text = "Exportation";
            // 
            // button_ExportSubList_Single
            // 
            button_ExportSubList_Single.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_ExportSubList_Single.Location = new Point(482, 595);
            button_ExportSubList_Single.Margin = new Padding(4, 3, 4, 3);
            button_ExportSubList_Single.Name = "button_ExportSubList_Single";
            button_ExportSubList_Single.Size = new Size(119, 45);
            button_ExportSubList_Single.TabIndex = 25;
            button_ExportSubList_Single.Tag = "1";
            button_ExportSubList_Single.Text = "Liste Secondaire actuelle";
            button_ExportSubList_Single.UseVisualStyleBackColor = true;
            button_ExportSubList_Single.Click += exportButtonAction;
            // 
            // button_DeletFromMainList
            // 
            button_DeletFromMainList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_DeletFromMainList.Location = new Point(4, 645);
            button_DeletFromMainList.Margin = new Padding(4, 3, 4, 3);
            button_DeletFromMainList.Name = "button_DeletFromMainList";
            button_DeletFromMainList.Size = new Size(455, 27);
            button_DeletFromMainList.TabIndex = 26;
            button_DeletFromMainList.Text = "Delete";
            button_DeletFromMainList.UseVisualStyleBackColor = true;
            button_DeletFromMainList.Click += button1_Click_1;
            // 
            // UserControl_RessourcesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(button_DeletFromMainList);
            Controls.Add(button_ExportSubList_Single);
            Controls.Add(label_Export);
            Controls.Add(button_ExportSubList_All);
            Controls.Add(button_ExportMain);
            Controls.Add(comboBox_addMainList);
            Controls.Add(button_addToMainList);
            Controls.Add(textBox_addMainList);
            Controls.Add(button_DeletSubList);
            Controls.Add(button_removeSubList);
            Controls.Add(button_NewSubList);
            Controls.Add(button_save);
            Controls.Add(label_SubListNameTitle);
            Controls.Add(textBox_SubListName);
            Controls.Add(comboBox_SubList);
            Controls.Add(button_moveRight);
            Controls.Add(flowLayoutPanel_SubList);
            Controls.Add(flowLayoutPanel_MainList);
            Controls.Add(label_Title);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControl_RessourcesList";
            Size = new Size(1085, 675);
            ResumeLayout(false);
            PerformLayout();
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
