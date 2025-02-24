namespace GUI_server
{
    partial class UserControl_main
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
            this.textBox_ClassName = new System.Windows.Forms.TextBox();
            this.label_sub_title = new System.Windows.Forms.Label();
            this.button_validateClassName = new System.Windows.Forms.Button();
            this.label_PcName = new System.Windows.Forms.Label();
            this.flowLayoutPanel_pcList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_className = new System.Windows.Forms.Panel();
            this.panel_modifyClassName = new System.Windows.Forms.Panel();
            this.label_ChangeClass_detais = new System.Windows.Forms.Label();
            this.textBox_NewPcName = new System.Windows.Forms.TextBox();
            this.label_changeClass_title = new System.Windows.Forms.Label();
            this.button_modifyClass = new System.Windows.Forms.Button();
            this.button_startScan = new System.Windows.Forms.Button();
            this.panel_ressourcesList = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_ressourcesList = new System.Windows.Forms.ComboBox();
            this.panel_className.SuspendLayout();
            this.panel_modifyClassName.SuspendLayout();
            this.panel_ressourcesList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(290, 1);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(197, 42);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "Main Page";
            // 
            // textBox_ClassName
            // 
            this.textBox_ClassName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_ClassName.Location = new System.Drawing.Point(15, 59);
            this.textBox_ClassName.Name = "textBox_ClassName";
            this.textBox_ClassName.Size = new System.Drawing.Size(206, 20);
            this.textBox_ClassName.TabIndex = 4;
            this.textBox_ClassName.Text = "A11";
            // 
            // label_sub_title
            // 
            this.label_sub_title.AutoSize = true;
            this.label_sub_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sub_title.Location = new System.Drawing.Point(11, 22);
            this.label_sub_title.Name = "label_sub_title";
            this.label_sub_title.Size = new System.Drawing.Size(210, 24);
            this.label_sub_title.TabIndex = 5;
            this.label_sub_title.Text = "Nom de la classe (salle)";
            // 
            // button_validateClassName
            // 
            this.button_validateClassName.Location = new System.Drawing.Point(72, 85);
            this.button_validateClassName.Name = "button_validateClassName";
            this.button_validateClassName.Size = new System.Drawing.Size(75, 23);
            this.button_validateClassName.TabIndex = 6;
            this.button_validateClassName.Text = "Recherche";
            this.button_validateClassName.UseVisualStyleBackColor = true;
            this.button_validateClassName.Click += new System.EventHandler(this.button_validateClassName_Click);
            // 
            // label_PcName
            // 
            this.label_PcName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PcName.AutoSize = true;
            this.label_PcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PcName.Location = new System.Drawing.Point(481, 58);
            this.label_PcName.Name = "label_PcName";
            this.label_PcName.Size = new System.Drawing.Size(225, 24);
            this.label_PcName.TabIndex = 8;
            this.label_PcName.Text = "Nomenclature des postes";
            // 
            // flowLayoutPanel_pcList
            // 
            this.flowLayoutPanel_pcList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_pcList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel_pcList.Location = new System.Drawing.Point(440, 86);
            this.flowLayoutPanel_pcList.Name = "flowLayoutPanel_pcList";
            this.flowLayoutPanel_pcList.Size = new System.Drawing.Size(312, 375);
            this.flowLayoutPanel_pcList.TabIndex = 9;
            // 
            // panel_className
            // 
            this.panel_className.Controls.Add(this.textBox_ClassName);
            this.panel_className.Controls.Add(this.label_sub_title);
            this.panel_className.Controls.Add(this.button_validateClassName);
            this.panel_className.Location = new System.Drawing.Point(50, 68);
            this.panel_className.Name = "panel_className";
            this.panel_className.Size = new System.Drawing.Size(233, 130);
            this.panel_className.TabIndex = 10;
            // 
            // panel_modifyClassName
            // 
            this.panel_modifyClassName.Controls.Add(this.label_ChangeClass_detais);
            this.panel_modifyClassName.Controls.Add(this.textBox_NewPcName);
            this.panel_modifyClassName.Controls.Add(this.label_changeClass_title);
            this.panel_modifyClassName.Controls.Add(this.button_modifyClass);
            this.panel_modifyClassName.Location = new System.Drawing.Point(50, 204);
            this.panel_modifyClassName.Name = "panel_modifyClassName";
            this.panel_modifyClassName.Size = new System.Drawing.Size(233, 151);
            this.panel_modifyClassName.TabIndex = 11;
            this.panel_modifyClassName.Visible = false;
            // 
            // label_ChangeClass_detais
            // 
            this.label_ChangeClass_detais.Location = new System.Drawing.Point(38, 46);
            this.label_ChangeClass_detais.Name = "label_ChangeClass_detais";
            this.label_ChangeClass_detais.Size = new System.Drawing.Size(157, 41);
            this.label_ChangeClass_detais.TabIndex = 7;
            this.label_ChangeClass_detais.Text = "Mettez le nom des pc sans les deux derniers digits";
            this.label_ChangeClass_detais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_NewPcName
            // 
            this.textBox_NewPcName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_NewPcName.Location = new System.Drawing.Point(15, 90);
            this.textBox_NewPcName.Name = "textBox_NewPcName";
            this.textBox_NewPcName.Size = new System.Drawing.Size(206, 20);
            this.textBox_NewPcName.TabIndex = 4;
            // 
            // label_changeClass_title
            // 
            this.label_changeClass_title.AutoSize = true;
            this.label_changeClass_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_changeClass_title.Location = new System.Drawing.Point(11, 22);
            this.label_changeClass_title.Name = "label_changeClass_title";
            this.label_changeClass_title.Size = new System.Drawing.Size(217, 24);
            this.label_changeClass_title.TabIndex = 5;
            this.label_changeClass_title.Text = "Modifier la nomenclature";
            // 
            // button_modifyClass
            // 
            this.button_modifyClass.Location = new System.Drawing.Point(72, 116);
            this.button_modifyClass.Name = "button_modifyClass";
            this.button_modifyClass.Size = new System.Drawing.Size(75, 23);
            this.button_modifyClass.TabIndex = 6;
            this.button_modifyClass.Text = "Modifier";
            this.button_modifyClass.UseVisualStyleBackColor = true;
            this.button_modifyClass.Click += new System.EventHandler(this.button_modifyClass_Click);
            // 
            // button_startScan
            // 
            this.button_startScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_startScan.Enabled = false;
            this.button_startScan.Location = new System.Drawing.Point(484, 467);
            this.button_startScan.Name = "button_startScan";
            this.button_startScan.Size = new System.Drawing.Size(233, 50);
            this.button_startScan.TabIndex = 13;
            this.button_startScan.Text = "Lancer Le Scan";
            this.button_startScan.UseVisualStyleBackColor = true;
            this.button_startScan.Click += new System.EventHandler(this.button_startScan_Click);
            // 
            // panel_ressourcesList
            // 
            this.panel_ressourcesList.Controls.Add(this.comboBox_ressourcesList);
            this.panel_ressourcesList.Controls.Add(this.label2);
            this.panel_ressourcesList.Controls.Add(this.button1);
            this.panel_ressourcesList.Location = new System.Drawing.Point(29, 361);
            this.panel_ressourcesList.Name = "panel_ressourcesList";
            this.panel_ressourcesList.Size = new System.Drawing.Size(278, 100);
            this.panel_ressourcesList.TabIndex = 12;
            this.panel_ressourcesList.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liste des ressources bannies";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox_ressourcesList
            // 
            this.comboBox_ressourcesList.FormattingEnabled = true;
            this.comboBox_ressourcesList.Location = new System.Drawing.Point(36, 49);
            this.comboBox_ressourcesList.Name = "comboBox_ressourcesList";
            this.comboBox_ressourcesList.Size = new System.Drawing.Size(206, 21);
            this.comboBox_ressourcesList.TabIndex = 7;
            this.comboBox_ressourcesList.SelectedIndexChanged += new System.EventHandler(this.comboBox_ressourcesList_SelectedIndexChanged);
            // 
            // UserControl_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel_ressourcesList);
            this.Controls.Add(this.button_startScan);
            this.Controls.Add(this.panel_modifyClassName);
            this.Controls.Add(this.panel_className);
            this.Controls.Add(this.flowLayoutPanel_pcList);
            this.Controls.Add(this.label_PcName);
            this.Controls.Add(this.label_Title);
            this.Name = "UserControl_main";
            this.Size = new System.Drawing.Size(777, 534);
            this.panel_className.ResumeLayout(false);
            this.panel_className.PerformLayout();
            this.panel_modifyClassName.ResumeLayout(false);
            this.panel_modifyClassName.PerformLayout();
            this.panel_ressourcesList.ResumeLayout(false);
            this.panel_ressourcesList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_ClassName;
        private System.Windows.Forms.Label label_sub_title;
        private System.Windows.Forms.Button button_validateClassName;
        private System.Windows.Forms.Label label_PcName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_pcList;
        private System.Windows.Forms.Panel panel_className;
        private System.Windows.Forms.Panel panel_modifyClassName;
        private System.Windows.Forms.TextBox textBox_NewPcName;
        private System.Windows.Forms.Label label_changeClass_title;
        private System.Windows.Forms.Button button_modifyClass;
        private System.Windows.Forms.Label label_ChangeClass_detais;
        private System.Windows.Forms.Button button_startScan;
        private System.Windows.Forms.Panel panel_ressourcesList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_ressourcesList;
    }
}
