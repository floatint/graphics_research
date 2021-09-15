namespace Lab_1
{
    partial class ConvolutionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.convolutedImagePictureBox = new System.Windows.Forms.PictureBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.kernelMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editKernelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultKernelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.convolutedImagePictureBox)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // convolutedImagePictureBox
            // 
            this.convolutedImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolutedImagePictureBox.Location = new System.Drawing.Point(0, 24);
            this.convolutedImagePictureBox.Name = "convolutedImagePictureBox";
            this.convolutedImagePictureBox.Size = new System.Drawing.Size(800, 426);
            this.convolutedImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.convolutedImagePictureBox.TabIndex = 0;
            this.convolutedImagePictureBox.TabStop = false;
            this.convolutedImagePictureBox.WaitOnLoad = true;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kernelMainMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // kernelMainMenuItem
            // 
            this.kernelMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editKernelMenuItem,
            this.defaultKernelMenuItem});
            this.kernelMainMenuItem.Name = "kernelMainMenuItem";
            this.kernelMainMenuItem.Size = new System.Drawing.Size(52, 20);
            this.kernelMainMenuItem.Text = "Kernel";
            // 
            // editKernelMenuItem
            // 
            this.editKernelMenuItem.Name = "editKernelMenuItem";
            this.editKernelMenuItem.Size = new System.Drawing.Size(112, 22);
            this.editKernelMenuItem.Text = "Edit";
            this.editKernelMenuItem.Click += new System.EventHandler(this.editKernelMenuItem_Click);
            // 
            // defaultKernelMenuItem
            // 
            this.defaultKernelMenuItem.Name = "defaultKernelMenuItem";
            this.defaultKernelMenuItem.Size = new System.Drawing.Size(112, 22);
            this.defaultKernelMenuItem.Text = "Default";
            // 
            // ConvolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convolutedImagePictureBox);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "ConvolutionForm";
            this.Text = "Convolution";
            ((System.ComponentModel.ISupportInitialize)(this.convolutedImagePictureBox)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox convolutedImagePictureBox;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem kernelMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editKernelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultKernelMenuItem;
    }
}