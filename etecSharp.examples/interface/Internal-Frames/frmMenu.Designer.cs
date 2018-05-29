namespace UIInternalFrame
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.fixeduniqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWindowName = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.icoNewWindow = new System.Windows.Forms.ToolStripButton();
            this.icoResize = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.icoClose = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuNewWindow,
            this.txtWindowName});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // btnMenuNewWindow
            // 
            this.btnMenuNewWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixeduniqueToolStripMenuItem,
            this.variousToolStripMenuItem});
            this.btnMenuNewWindow.Name = "btnMenuNewWindow";
            this.btnMenuNewWindow.Size = new System.Drawing.Size(90, 24);
            this.btnMenuNewWindow.Text = "New Window";
            // 
            // fixeduniqueToolStripMenuItem
            // 
            this.fixeduniqueToolStripMenuItem.Name = "fixeduniqueToolStripMenuItem";
            this.fixeduniqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fixeduniqueToolStripMenuItem.Text = "Fixed/unique";
            this.fixeduniqueToolStripMenuItem.Click += new System.EventHandler(this.newWindowUnique);
            // 
            // variousToolStripMenuItem
            // 
            this.variousToolStripMenuItem.Name = "variousToolStripMenuItem";
            this.variousToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.variousToolStripMenuItem.Text = "Various";
            this.variousToolStripMenuItem.Click += new System.EventHandler(this.newWindowMultiple);
            // 
            // txtWindowName
            // 
            this.txtWindowName.AccessibleDescription = "name of the window";
            this.txtWindowName.Name = "txtWindowName";
            this.txtWindowName.Size = new System.Drawing.Size(100, 24);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem1.Text = "New Window";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.newWindowUnique);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.icoNewWindow,
            this.icoResize,
            this.toolStripSeparator1,
            this.icoClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(704, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // icoNewWindow
            // 
            this.icoNewWindow.Image = ((System.Drawing.Image)(resources.GetObject("icoNewWindow.Image")));
            this.icoNewWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.icoNewWindow.Name = "icoNewWindow";
            this.icoNewWindow.Size = new System.Drawing.Size(96, 22);
            this.icoNewWindow.Text = "New window";
            this.icoNewWindow.ToolTipText = "Open a new window";
            this.icoNewWindow.Click += new System.EventHandler(this.newWindowMultiple);
            // 
            // icoResize
            // 
            this.icoResize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.icoResize.Image = ((System.Drawing.Image)(resources.GetObject("icoResize.Image")));
            this.icoResize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.icoResize.Name = "icoResize";
            this.icoResize.Size = new System.Drawing.Size(23, 22);
            this.icoResize.Text = "Toggle resizable";
            this.icoResize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.icoResize.ToolTipText = "Toggle resizable window";
            this.icoResize.Click += new System.EventHandler(this.toggleResizable);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // icoClose
            // 
            this.icoClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.icoClose.Image = ((System.Drawing.Image)(resources.GetObject("icoClose.Image")));
            this.icoClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.icoClose.Name = "icoClose";
            this.icoClose.Size = new System.Drawing.Size(23, 22);
            this.icoClose.Text = "Close";
            this.icoClose.ToolTipText = "Close application";
            this.icoClose.Click += new System.EventHandler(this.closeApplication);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuNewWindow;
        private System.Windows.Forms.ToolStripTextBox txtWindowName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton icoNewWindow;
        private System.Windows.Forms.ToolStripButton icoResize;
        private System.Windows.Forms.ToolStripButton icoClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fixeduniqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variousToolStripMenuItem;
    }
}

