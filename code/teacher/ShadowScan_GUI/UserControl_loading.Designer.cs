namespace ShadowScan_GUI
{
    partial class UserControl_loading
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
            pictureBox_gif = new PictureBox();
            label_loadingTitle = new Label();
            textBox_Message = new TextBox();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox_gif).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_gif
            // 
            pictureBox_gif.Anchor = AnchorStyles.None;
            pictureBox_gif.Image = Properties.Resources.loading;
            pictureBox_gif.Location = new Point(204, 202);
            pictureBox_gif.Margin = new Padding(4, 3, 4, 3);
            pictureBox_gif.Name = "pictureBox_gif";
            pictureBox_gif.Size = new Size(175, 175);
            pictureBox_gif.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_gif.TabIndex = 0;
            pictureBox_gif.TabStop = false;
            // 
            // label_loadingTitle
            // 
            label_loadingTitle.Anchor = AnchorStyles.None;
            label_loadingTitle.AutoSize = true;
            label_loadingTitle.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_loadingTitle.Location = new Point(103, 115);
            label_loadingTitle.Margin = new Padding(4, 0, 4, 0);
            label_loadingTitle.Name = "label_loadingTitle";
            label_loadingTitle.Size = new Size(377, 42);
            label_loadingTitle.TabIndex = 1;
            label_loadingTitle.Text = "Chargement en cours";
            // 
            // textBox_Message
            // 
            textBox_Message.AcceptsReturn = true;
            textBox_Message.AcceptsTab = true;
            textBox_Message.Anchor = AnchorStyles.None;
            textBox_Message.Location = new Point(166, 441);
            textBox_Message.Margin = new Padding(4, 3, 4, 3);
            textBox_Message.Name = "textBox_Message";
            textBox_Message.ReadOnly = true;
            textBox_Message.Size = new Size(250, 23);
            textBox_Message.TabIndex = 2;
            textBox_Message.TextAlign = HorizontalAlignment.Center;
            textBox_Message.Visible = false;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.None;
            progressBar.Location = new Point(103, 497);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(377, 23);
            progressBar.TabIndex = 3;
            // 
            // UserControl_loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(progressBar);
            Controls.Add(textBox_Message);
            Controls.Add(label_loadingTitle);
            Controls.Add(pictureBox_gif);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControl_loading";
            Size = new Size(583, 577);
            ((System.ComponentModel.ISupportInitialize)pictureBox_gif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_gif;
        private System.Windows.Forms.Label label_loadingTitle;
        private System.Windows.Forms.TextBox textBox_Message;
        private ProgressBar progressBar;
    }
}
