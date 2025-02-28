namespace ShadowScan_GUI
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
            label_Title = new Label();
            textBox_ClassName = new TextBox();
            label_sub_title = new Label();
            button_validateClassName = new Button();
            label_PcName = new Label();
            flowLayoutPanel_pcList = new FlowLayoutPanel();
            panel_className = new Panel();
            panel_modifyClassName = new Panel();
            label_ChangeClass_detais = new Label();
            textBox_NewPcName = new TextBox();
            label_changeClass_title = new Label();
            button_modifyClass = new Button();
            button_startScan = new Button();
            panel_ressourcesList = new Panel();
            comboBox_ressourcesList = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            panel_className.SuspendLayout();
            panel_modifyClassName.SuspendLayout();
            panel_ressourcesList.SuspendLayout();
            SuspendLayout();
            // 
            // label_Title
            // 
            label_Title.Anchor = AnchorStyles.Top;
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Title.Location = new Point(338, 1);
            label_Title.Margin = new Padding(4, 0, 4, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(197, 42);
            label_Title.TabIndex = 3;
            label_Title.Text = "Main Page";
            // 
            // textBox_ClassName
            // 
            textBox_ClassName.BackColor = SystemColors.ScrollBar;
            textBox_ClassName.Location = new Point(18, 68);
            textBox_ClassName.Margin = new Padding(4, 3, 4, 3);
            textBox_ClassName.Name = "textBox_ClassName";
            textBox_ClassName.Size = new Size(240, 23);
            textBox_ClassName.TabIndex = 4;
            textBox_ClassName.Text = "A11";
            // 
            // label_sub_title
            // 
            label_sub_title.AutoSize = true;
            label_sub_title.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_sub_title.Location = new Point(13, 25);
            label_sub_title.Margin = new Padding(4, 0, 4, 0);
            label_sub_title.Name = "label_sub_title";
            label_sub_title.Size = new Size(210, 24);
            label_sub_title.TabIndex = 5;
            label_sub_title.Text = "Nom de la classe (salle)";
            // 
            // button_validateClassName
            // 
            button_validateClassName.Location = new Point(84, 98);
            button_validateClassName.Margin = new Padding(4, 3, 4, 3);
            button_validateClassName.Name = "button_validateClassName";
            button_validateClassName.Size = new Size(88, 27);
            button_validateClassName.TabIndex = 6;
            button_validateClassName.Text = "Recherche";
            button_validateClassName.UseVisualStyleBackColor = true;
            button_validateClassName.Click += button_validateClassName_Click;
            // 
            // label_PcName
            // 
            label_PcName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_PcName.AutoSize = true;
            label_PcName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_PcName.Location = new Point(626, 72);
            label_PcName.Margin = new Padding(4, 0, 4, 0);
            label_PcName.Name = "label_PcName";
            label_PcName.Size = new Size(144, 24);
            label_PcName.TabIndex = 8;
            label_PcName.Text = "Liste des postes";
            // 
            // flowLayoutPanel_pcList
            // 
            flowLayoutPanel_pcList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel_pcList.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel_pcList.Location = new Point(511, 99);
            flowLayoutPanel_pcList.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel_pcList.Name = "flowLayoutPanel_pcList";
            flowLayoutPanel_pcList.Size = new Size(366, 433);
            flowLayoutPanel_pcList.TabIndex = 9;
            // 
            // panel_className
            // 
            panel_className.Controls.Add(textBox_ClassName);
            panel_className.Controls.Add(label_sub_title);
            panel_className.Controls.Add(button_validateClassName);
            panel_className.Location = new Point(58, 78);
            panel_className.Margin = new Padding(4, 3, 4, 3);
            panel_className.Name = "panel_className";
            panel_className.Size = new Size(272, 150);
            panel_className.TabIndex = 10;
            // 
            // panel_modifyClassName
            // 
            panel_modifyClassName.Controls.Add(label_ChangeClass_detais);
            panel_modifyClassName.Controls.Add(textBox_NewPcName);
            panel_modifyClassName.Controls.Add(label_changeClass_title);
            panel_modifyClassName.Controls.Add(button_modifyClass);
            panel_modifyClassName.Location = new Point(58, 235);
            panel_modifyClassName.Margin = new Padding(4, 3, 4, 3);
            panel_modifyClassName.Name = "panel_modifyClassName";
            panel_modifyClassName.Size = new Size(272, 174);
            panel_modifyClassName.TabIndex = 11;
            panel_modifyClassName.Visible = false;
            // 
            // label_ChangeClass_detais
            // 
            label_ChangeClass_detais.Location = new Point(44, 53);
            label_ChangeClass_detais.Margin = new Padding(4, 0, 4, 0);
            label_ChangeClass_detais.Name = "label_ChangeClass_detais";
            label_ChangeClass_detais.Size = new Size(183, 47);
            label_ChangeClass_detais.TabIndex = 7;
            label_ChangeClass_detais.Text = "Mettez le nom des pc sans les deux derniers digits";
            label_ChangeClass_detais.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_NewPcName
            // 
            textBox_NewPcName.BackColor = SystemColors.ScrollBar;
            textBox_NewPcName.Location = new Point(18, 104);
            textBox_NewPcName.Margin = new Padding(4, 3, 4, 3);
            textBox_NewPcName.Name = "textBox_NewPcName";
            textBox_NewPcName.Size = new Size(240, 23);
            textBox_NewPcName.TabIndex = 4;
            // 
            // label_changeClass_title
            // 
            label_changeClass_title.AutoSize = true;
            label_changeClass_title.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_changeClass_title.Location = new Point(13, 25);
            label_changeClass_title.Margin = new Padding(4, 0, 4, 0);
            label_changeClass_title.Name = "label_changeClass_title";
            label_changeClass_title.Size = new Size(217, 24);
            label_changeClass_title.TabIndex = 5;
            label_changeClass_title.Text = "Modifier la nomenclature";
            // 
            // button_modifyClass
            // 
            button_modifyClass.Location = new Point(84, 134);
            button_modifyClass.Margin = new Padding(4, 3, 4, 3);
            button_modifyClass.Name = "button_modifyClass";
            button_modifyClass.Size = new Size(88, 27);
            button_modifyClass.TabIndex = 6;
            button_modifyClass.Text = "Modifier";
            button_modifyClass.UseVisualStyleBackColor = true;
            button_modifyClass.Click += button_modifyClass_Click;
            // 
            // button_startScan
            // 
            button_startScan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_startScan.Enabled = false;
            button_startScan.Location = new Point(548, 538);
            button_startScan.Margin = new Padding(4, 3, 4, 3);
            button_startScan.Name = "button_startScan";
            button_startScan.Size = new Size(272, 58);
            button_startScan.TabIndex = 13;
            button_startScan.Text = "Lancer Le Scan";
            button_startScan.UseVisualStyleBackColor = true;
            button_startScan.Click += button_startScan_Click;
            // 
            // panel_ressourcesList
            // 
            panel_ressourcesList.Controls.Add(comboBox_ressourcesList);
            panel_ressourcesList.Controls.Add(label2);
            panel_ressourcesList.Controls.Add(button1);
            panel_ressourcesList.Location = new Point(34, 417);
            panel_ressourcesList.Margin = new Padding(4, 3, 4, 3);
            panel_ressourcesList.Name = "panel_ressourcesList";
            panel_ressourcesList.Size = new Size(324, 115);
            panel_ressourcesList.TabIndex = 12;
            panel_ressourcesList.Visible = false;
            // 
            // comboBox_ressourcesList
            // 
            comboBox_ressourcesList.BackColor = SystemColors.ScrollBar;
            comboBox_ressourcesList.FormattingEnabled = true;
            comboBox_ressourcesList.Location = new Point(42, 57);
            comboBox_ressourcesList.Margin = new Padding(4, 3, 4, 3);
            comboBox_ressourcesList.Name = "comboBox_ressourcesList";
            comboBox_ressourcesList.Size = new Size(240, 23);
            comboBox_ressourcesList.TabIndex = 7;
            comboBox_ressourcesList.SelectedIndexChanged += comboBox_ressourcesList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(254, 24);
            label2.TabIndex = 5;
            label2.Text = "Liste des ressources bannies";
            // 
            // button1
            // 
            button1.Location = new Point(119, 87);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 6;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            // 
            // UserControl_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(panel_ressourcesList);
            Controls.Add(button_startScan);
            Controls.Add(panel_modifyClassName);
            Controls.Add(panel_className);
            Controls.Add(flowLayoutPanel_pcList);
            Controls.Add(label_PcName);
            Controls.Add(label_Title);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControl_main";
            Size = new Size(906, 616);
            panel_className.ResumeLayout(false);
            panel_className.PerformLayout();
            panel_modifyClassName.ResumeLayout(false);
            panel_modifyClassName.PerformLayout();
            panel_ressourcesList.ResumeLayout(false);
            panel_ressourcesList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
