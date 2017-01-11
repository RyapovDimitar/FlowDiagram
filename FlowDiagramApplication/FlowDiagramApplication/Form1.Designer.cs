namespace FlowDiagramApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            this.btnPump = new System.Windows.Forms.ToolStripButton();
            this.btnSink = new System.Windows.Forms.ToolStripButton();
            this.btnSplitter = new System.Windows.Forms.ToolStripButton();
            this.btnAdjSplitter = new System.Windows.Forms.ToolStripButton();
            this.btnMerger = new System.Windows.Forms.ToolStripButton();
            this.btnPipeline = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.workplaceToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(861, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // workplaceToolStripMenuItem
            // 
            this.workplaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearNetworkToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.workplaceToolStripMenuItem.Name = "workplaceToolStripMenuItem";
            this.workplaceToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.workplaceToolStripMenuItem.Text = "Workplace";
            // 
            // clearNetworkToolStripMenuItem
            // 
            this.clearNetworkToolStripMenuItem.Name = "clearNetworkToolStripMenuItem";
            this.clearNetworkToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.clearNetworkToolStripMenuItem.Text = "Clear network";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.propertiesToolStripMenuItem.Text = "Network properties";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 716);
            this.panel1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnSelect,
            this.btnDelete,
            this.btnPump,
            this.btnSink,
            this.btnSplitter,
            this.btnAdjSplitter,
            this.btnMerger,
            this.btnPipeline});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(100, 698);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSelect
            // 
            this.btnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelect.Margin = new System.Windows.Forms.Padding(5, 10, 5, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 24);
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnPump
            // 
            this.btnPump.CheckOnClick = true;
            this.btnPump.Image = ((System.Drawing.Image)(resources.GetObject("btnPump.Image")));
            this.btnPump.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPump.ImageTransparentColor = System.Drawing.Color.White;
            this.btnPump.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnPump.Name = "btnPump";
            this.btnPump.Size = new System.Drawing.Size(88, 74);
            this.btnPump.Tag = "Pump";
            this.btnPump.Text = "Pump";
            this.btnPump.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnPump.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPump.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // btnSink
            // 
            this.btnSink.CheckOnClick = true;
            this.btnSink.Image = ((System.Drawing.Image)(resources.GetObject("btnSink.Image")));
            this.btnSink.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSink.ImageTransparentColor = System.Drawing.Color.White;
            this.btnSink.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnSink.Name = "btnSink";
            this.btnSink.Size = new System.Drawing.Size(88, 74);
            this.btnSink.Tag = "Sink";
            this.btnSink.Text = "Sink";
            this.btnSink.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnSink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSink.ToolTipText = "Sink";
            this.btnSink.Click += new System.EventHandler(this.btnSink_Click);
            // 
            // btnSplitter
            // 
            this.btnSplitter.CheckOnClick = true;
            this.btnSplitter.Image = ((System.Drawing.Image)(resources.GetObject("btnSplitter.Image")));
            this.btnSplitter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSplitter.ImageTransparentColor = System.Drawing.Color.White;
            this.btnSplitter.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnSplitter.Name = "btnSplitter";
            this.btnSplitter.Size = new System.Drawing.Size(88, 74);
            this.btnSplitter.Tag = "Splitter";
            this.btnSplitter.Text = "Splitter";
            this.btnSplitter.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnSplitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSplitter.Click += new System.EventHandler(this.btnSplitter_Click);
            // 
            // btnAdjSplitter
            // 
            this.btnAdjSplitter.CheckOnClick = true;
            this.btnAdjSplitter.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjSplitter.Image")));
            this.btnAdjSplitter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdjSplitter.ImageTransparentColor = System.Drawing.Color.White;
            this.btnAdjSplitter.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnAdjSplitter.Name = "btnAdjSplitter";
            this.btnAdjSplitter.Size = new System.Drawing.Size(88, 74);
            this.btnAdjSplitter.Tag = "Adj. splitter";
            this.btnAdjSplitter.Text = "Adj. splitter";
            this.btnAdjSplitter.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnAdjSplitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdjSplitter.Click += new System.EventHandler(this.btnAdjSplitter_Click);
            // 
            // btnMerger
            // 
            this.btnMerger.CheckOnClick = true;
            this.btnMerger.Image = ((System.Drawing.Image)(resources.GetObject("btnMerger.Image")));
            this.btnMerger.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMerger.ImageTransparentColor = System.Drawing.Color.White;
            this.btnMerger.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnMerger.Name = "btnMerger";
            this.btnMerger.Size = new System.Drawing.Size(88, 74);
            this.btnMerger.Tag = "Merger";
            this.btnMerger.Text = "Merger";
            this.btnMerger.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnMerger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMerger.Click += new System.EventHandler(this.btnMerger_Click);
            // 
            // btnPipeline
            // 
            this.btnPipeline.CheckOnClick = true;
            this.btnPipeline.Image = ((System.Drawing.Image)(resources.GetObject("btnPipeline.Image")));
            this.btnPipeline.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPipeline.ImageTransparentColor = System.Drawing.Color.White;
            this.btnPipeline.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnPipeline.Name = "btnPipeline";
            this.btnPipeline.Size = new System.Drawing.Size(88, 74);
            this.btnPipeline.Tag = "Pipeline";
            this.btnPipeline.Text = "Pipeline";
            this.btnPipeline.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnPipeline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPipeline.Click += new System.EventHandler(this.btnPipeline_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 10, 5, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 24);
            this.toolStripButton1.Text = "Properties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private System.Windows.Forms.ToolStripButton btnPump;
        private System.Windows.Forms.ToolStripButton btnSink;
        private System.Windows.Forms.ToolStripButton btnSplitter;
        private System.Windows.Forms.ToolStripButton btnAdjSplitter;
        private System.Windows.Forms.ToolStripButton btnMerger;
        private System.Windows.Forms.ToolStripButton btnPipeline;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

