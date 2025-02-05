namespace GUI_server
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
            this.pictureBox_gif = new System.Windows.Forms.PictureBox();
            this.label_loadingTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_gif
            // 
            this.pictureBox_gif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_gif.Image = global::GUI_server.Properties.Resources.loading_gif;
            this.pictureBox_gif.Location = new System.Drawing.Point(175, 175);
            this.pictureBox_gif.Name = "pictureBox_gif";
            this.pictureBox_gif.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_gif.TabIndex = 0;
            this.pictureBox_gif.TabStop = false;
            // 
            // label_loadingTitle
            // 
            this.label_loadingTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_loadingTitle.AutoSize = true;
            this.label_loadingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loadingTitle.Location = new System.Drawing.Point(62, 100);
            this.label_loadingTitle.Name = "label_loadingTitle";
            this.label_loadingTitle.Size = new System.Drawing.Size(377, 42);
            this.label_loadingTitle.TabIndex = 1;
            this.label_loadingTitle.Text = "Chargement en cours";
            // 
            // UserControl_loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_loadingTitle);
            this.Controls.Add(this.pictureBox_gif);
            this.Name = "UserControl_loading";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_gif;
        private System.Windows.Forms.Label label_loadingTitle;
    }
}
