namespace Lab_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.imageMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformationMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceImagePictureBox = new System.Windows.Forms.PictureBox();
            this.convolutionTranformationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageMainMenuItem,
            this.transformationMainMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // imageMainMenuItem
            // 
            this.imageMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageMenuItem,
            this.closeImageMenuItem});
            this.imageMainMenuItem.Name = "imageMainMenuItem";
            this.imageMainMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageMainMenuItem.Text = "Image";
            // 
            // openImageMenuItem
            // 
            this.openImageMenuItem.Name = "openImageMenuItem";
            this.openImageMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openImageMenuItem.Text = "Open";
            this.openImageMenuItem.Click += new System.EventHandler(this.openImageMenuItem_Click);
            // 
            // closeImageMenuItem
            // 
            this.closeImageMenuItem.Name = "closeImageMenuItem";
            this.closeImageMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeImageMenuItem.Text = "Close";
            this.closeImageMenuItem.Click += new System.EventHandler(this.closeImageMenuItem_Click);
            // 
            // transformationMainMenuItem
            // 
            this.transformationMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convolutionTranformationMenuItem});
            this.transformationMainMenuItem.Name = "transformationMainMenuItem";
            this.transformationMainMenuItem.Size = new System.Drawing.Size(101, 20);
            this.transformationMainMenuItem.Text = "Transformation";
            // 
            // sourceImagePictureBox
            // 
            this.sourceImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceImagePictureBox.Location = new System.Drawing.Point(0, 24);
            this.sourceImagePictureBox.Name = "sourceImagePictureBox";
            this.sourceImagePictureBox.Size = new System.Drawing.Size(800, 438);
            this.sourceImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sourceImagePictureBox.TabIndex = 1;
            this.sourceImagePictureBox.TabStop = false;
            // 
            // convolutionTranformationMenuItem
            // 
            this.convolutionTranformationMenuItem.Name = "convolutionTranformationMenuItem";
            this.convolutionTranformationMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convolutionTranformationMenuItem.Text = "Convolution";
            this.convolutionTranformationMenuItem.Click += new System.EventHandler(this.convolutionTranformationMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.sourceImagePictureBox);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Source image";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem imageMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeImageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformationMainMenuItem;
        private System.Windows.Forms.PictureBox sourceImagePictureBox;
        private System.Windows.Forms.ToolStripMenuItem convolutionTranformationMenuItem;
    }
}

