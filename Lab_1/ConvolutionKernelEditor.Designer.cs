namespace Lab_1
{
    partial class ConvolutionKernelEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.kernelItemsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.providerMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toFileProviderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileProviderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.kernelItemsTableLayout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 187);
            this.panel1.TabIndex = 0;
            // 
            // kernelItemsTableLayout
            // 
            this.kernelItemsTableLayout.AutoSize = true;
            this.kernelItemsTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.kernelItemsTableLayout.ColumnCount = 1;
            this.kernelItemsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 573F));
            this.kernelItemsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kernelItemsTableLayout.Location = new System.Drawing.Point(0, 0);
            this.kernelItemsTableLayout.Name = "kernelItemsTableLayout";
            this.kernelItemsTableLayout.RowCount = 1;
            this.kernelItemsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.kernelItemsTableLayout.Size = new System.Drawing.Size(573, 187);
            this.kernelItemsTableLayout.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.providerMainMenuItem,
            this.rowMainMenuItem,
            this.columnMainMenuItem,
            this.okMainMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(573, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "mainMenu";
            // 
            // providerMainMenuItem
            // 
            this.providerMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toFileProviderMenuItem,
            this.fromFileProviderMenuItem});
            this.providerMainMenuItem.Name = "providerMainMenuItem";
            this.providerMainMenuItem.Size = new System.Drawing.Size(63, 20);
            this.providerMainMenuItem.Text = "Provider";
            // 
            // toFileProviderMenuItem
            // 
            this.toFileProviderMenuItem.Name = "toFileProviderMenuItem";
            this.toFileProviderMenuItem.Size = new System.Drawing.Size(121, 22);
            this.toFileProviderMenuItem.Text = "To file";
            this.toFileProviderMenuItem.Click += new System.EventHandler(this.toFileProviderMenuItem_Click);
            // 
            // fromFileProviderMenuItem
            // 
            this.fromFileProviderMenuItem.Name = "fromFileProviderMenuItem";
            this.fromFileProviderMenuItem.Size = new System.Drawing.Size(121, 22);
            this.fromFileProviderMenuItem.Text = "From file";
            this.fromFileProviderMenuItem.Click += new System.EventHandler(this.fromFileProviderMenuItem_Click);
            // 
            // rowMainMenuItem
            // 
            this.rowMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowMenuItem});
            this.rowMainMenuItem.Name = "rowMainMenuItem";
            this.rowMainMenuItem.Size = new System.Drawing.Size(42, 20);
            this.rowMainMenuItem.Text = "Row";
            // 
            // addRowMenuItem
            // 
            this.addRowMenuItem.Name = "addRowMenuItem";
            this.addRowMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addRowMenuItem.Text = "Add";
            this.addRowMenuItem.Click += new System.EventHandler(this.addRowMenuItem_Click);
            // 
            // columnMainMenuItem
            // 
            this.columnMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColumnMenuItem});
            this.columnMainMenuItem.Name = "columnMainMenuItem";
            this.columnMainMenuItem.Size = new System.Drawing.Size(62, 20);
            this.columnMainMenuItem.Text = "Column";
            // 
            // addColumnMenuItem
            // 
            this.addColumnMenuItem.Name = "addColumnMenuItem";
            this.addColumnMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addColumnMenuItem.Text = "Add";
            this.addColumnMenuItem.Click += new System.EventHandler(this.addColumnMenuItem_Click);
            // 
            // okMainMenuItem
            // 
            this.okMainMenuItem.Name = "okMainMenuItem";
            this.okMainMenuItem.Size = new System.Drawing.Size(34, 20);
            this.okMainMenuItem.Text = "Ok";
            this.okMainMenuItem.Click += new System.EventHandler(this.okMainMenuItem_Click);
            // 
            // ConvolutionKernelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "ConvolutionKernelEditor";
            this.Text = "Convolution kernel editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConvolutionKernelEditor_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel kernelItemsTableLayout;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem rowMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColumnMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providerMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toFileProviderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileProviderMenuItem;
    }
}