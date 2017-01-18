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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            this.btnMove = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnPump = new System.Windows.Forms.ToolStripButton();
            this.btnSink = new System.Windows.Forms.ToolStripButton();
            this.btnSplitter = new System.Windows.Forms.ToolStripButton();
            this.btnAdjSplitter = new System.Windows.Forms.ToolStripButton();
            this.btnMerger = new System.Windows.Forms.ToolStripButton();
            this.btnPipeline = new System.Windows.Forms.ToolStripButton();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.componentProperties = new System.Windows.Forms.GroupBox();
            this.tbFlow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSetRate = new System.Windows.Forms.GroupBox();
            this.tbSetRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.networkProperties = new System.Windows.Forms.GroupBox();
            this.tbGeneralSafetyLimit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPipeline = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPipeline = new System.Windows.Forms.TextBox();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.componentProperties.SuspendLayout();
            this.gbSetRate.SuspendLayout();
            this.networkProperties.SuspendLayout();
            this.gbPipeline.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.workplaceToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1011, 28);
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
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.openToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openToolStripMenuItem_MouseDown);
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
            this.clearNetworkToolStripMenuItem.Click += new System.EventHandler(this.clearNetworkToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.propertiesToolStripMenuItem.Text = "Network properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 684);
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
            this.btnMove,
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
            this.toolStrip1.Size = new System.Drawing.Size(100, 674);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 24);
            this.toolStripButton1.Text = "Properties";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.CheckOnClick = true;
            this.btnSelect.Image = global::FlowDiagramApplication.Properties.Resources.SelectIcon;
            this.btnSelect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.White;
            this.btnSelect.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 24);
            this.btnSelect.Tag = "Select";
            this.btnSelect.Text = "Select";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnMove
            // 
            this.btnMove.CheckOnClick = true;
            this.btnMove.Image = global::FlowDiagramApplication.Properties.Resources.SelectIcon;
            this.btnMove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMove.ImageTransparentColor = System.Drawing.Color.White;
            this.btnMove.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(88, 24);
            this.btnMove.Tag = "Move";
            this.btnMove.Text = "Move";
            this.btnMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMove.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CheckOnClick = true;
            this.btnDelete.Image = global::FlowDiagramApplication.Properties.Resources.DeleteIcon;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.White;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 24);
            this.btnDelete.Tag = "Delete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPump
            // 
            this.btnPump.CheckOnClick = true;
            this.btnPump.Image = global::FlowDiagramApplication.Properties.Resources.PumpIcon;
            this.btnPump.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPump.ImageTransparentColor = System.Drawing.Color.White;
            this.btnPump.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnPump.Name = "btnPump";
            this.btnPump.Size = new System.Drawing.Size(88, 64);
            this.btnPump.Tag = "Pump";
            this.btnPump.Text = "Pump";
            this.btnPump.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnPump.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPump.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // btnSink
            // 
            this.btnSink.CheckOnClick = true;
            this.btnSink.Image = global::FlowDiagramApplication.Properties.Resources.SinkIcon;
            this.btnSink.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSink.ImageTransparentColor = System.Drawing.Color.White;
            this.btnSink.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnSink.Name = "btnSink";
            this.btnSink.Size = new System.Drawing.Size(88, 64);
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
            this.btnSplitter.Image = global::FlowDiagramApplication.Properties.Resources.SplitterIcon;
            this.btnSplitter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSplitter.ImageTransparentColor = System.Drawing.Color.White;
            this.btnSplitter.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnSplitter.Name = "btnSplitter";
            this.btnSplitter.Size = new System.Drawing.Size(88, 64);
            this.btnSplitter.Tag = "Splitter";
            this.btnSplitter.Text = "Splitter";
            this.btnSplitter.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnSplitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSplitter.Click += new System.EventHandler(this.btnSplitter_Click);
            // 
            // btnAdjSplitter
            // 
            this.btnAdjSplitter.CheckOnClick = true;
            this.btnAdjSplitter.Image = global::FlowDiagramApplication.Properties.Resources.Adj__SplitterIcon;
            this.btnAdjSplitter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdjSplitter.ImageTransparentColor = System.Drawing.Color.White;
            this.btnAdjSplitter.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnAdjSplitter.Name = "btnAdjSplitter";
            this.btnAdjSplitter.Size = new System.Drawing.Size(88, 64);
            this.btnAdjSplitter.Tag = "Adj. splitter";
            this.btnAdjSplitter.Text = "Adj. splitter";
            this.btnAdjSplitter.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnAdjSplitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdjSplitter.Click += new System.EventHandler(this.btnAdjSplitter_Click);
            // 
            // btnMerger
            // 
            this.btnMerger.CheckOnClick = true;
            this.btnMerger.Image = global::FlowDiagramApplication.Properties.Resources.MergerIcon;
            this.btnMerger.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMerger.ImageTransparentColor = System.Drawing.Color.White;
            this.btnMerger.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnMerger.Name = "btnMerger";
            this.btnMerger.Size = new System.Drawing.Size(88, 64);
            this.btnMerger.Tag = "Merger";
            this.btnMerger.Text = "Merger";
            this.btnMerger.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnMerger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMerger.Click += new System.EventHandler(this.btnMerger_Click);
            // 
            // btnPipeline
            // 
            this.btnPipeline.CheckOnClick = true;
            this.btnPipeline.Image = global::FlowDiagramApplication.Properties.Resources.PipelineIcon;
            this.btnPipeline.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPipeline.ImageTransparentColor = System.Drawing.Color.White;
            this.btnPipeline.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnPipeline.Name = "btnPipeline";
            this.btnPipeline.Size = new System.Drawing.Size(88, 64);
            this.btnPipeline.Tag = "Pipeline";
            this.btnPipeline.Text = "Pipeline";
            this.btnPipeline.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnPipeline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPipeline.Click += new System.EventHandler(this.btnPipeline_Click);
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbCanvas.Location = new System.Drawing.Point(167, 54);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(661, 565);
            this.pbCanvas.TabIndex = 5;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Click += new System.EventHandler(this.pbCanvas_Click);
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            this.pbCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseDown);
            this.pbCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseMove);
            this.pbCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseUp);
            // 
            // componentProperties
            // 
            this.componentProperties.Controls.Add(this.tbFlow);
            this.componentProperties.Controls.Add(this.label2);
            this.componentProperties.Controls.Add(this.tbCapacity);
            this.componentProperties.Controls.Add(this.label1);
            this.componentProperties.Location = new System.Drawing.Point(834, 54);
            this.componentProperties.Name = "componentProperties";
            this.componentProperties.Size = new System.Drawing.Size(165, 127);
            this.componentProperties.TabIndex = 6;
            this.componentProperties.TabStop = false;
            this.componentProperties.Text = "Properties";
            this.componentProperties.Visible = false;
            // 
            // tbFlow
            // 
            this.tbFlow.Location = new System.Drawing.Point(10, 97);
            this.tbFlow.Name = "tbFlow";
            this.tbFlow.Size = new System.Drawing.Size(149, 22);
            this.tbFlow.TabIndex = 3;
            this.tbFlow.TextChanged += new System.EventHandler(this.tbFlow_TextChanged);
            this.tbFlow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFlow_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flow";
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(10, 43);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(149, 22);
            this.tbCapacity.TabIndex = 1;
            this.tbCapacity.TextChanged += new System.EventHandler(this.tbCapacity_TextChanged);
            this.tbCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCapacity_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capacity";
            // 
            // gbSetRate
            // 
            this.gbSetRate.Controls.Add(this.tbSetRate);
            this.gbSetRate.Controls.Add(this.label3);
            this.gbSetRate.Location = new System.Drawing.Point(834, 54);
            this.gbSetRate.Name = "gbSetRate";
            this.gbSetRate.Size = new System.Drawing.Size(165, 74);
            this.gbSetRate.TabIndex = 7;
            this.gbSetRate.TabStop = false;
            this.gbSetRate.Text = "Set rate";
            this.gbSetRate.Visible = false;
            // 
            // tbSetRate
            // 
            this.tbSetRate.Location = new System.Drawing.Point(11, 43);
            this.tbSetRate.Name = "tbSetRate";
            this.tbSetRate.Size = new System.Drawing.Size(148, 22);
            this.tbSetRate.TabIndex = 4;
            this.tbSetRate.TextChanged += new System.EventHandler(this.tbSetRate_TextChanged);
            this.tbSetRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSetRate_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rate";
            // 
            // networkProperties
            // 
            this.networkProperties.Controls.Add(this.tbGeneralSafetyLimit);
            this.networkProperties.Controls.Add(this.label4);
            this.networkProperties.Location = new System.Drawing.Point(834, 54);
            this.networkProperties.Name = "networkProperties";
            this.networkProperties.Size = new System.Drawing.Size(165, 74);
            this.networkProperties.TabIndex = 9;
            this.networkProperties.TabStop = false;
            this.networkProperties.Text = "Network properties";
            this.networkProperties.Visible = false;
            // 
            // tbGeneralSafetyLimit
            // 
            this.tbGeneralSafetyLimit.Location = new System.Drawing.Point(11, 43);
            this.tbGeneralSafetyLimit.Name = "tbGeneralSafetyLimit";
            this.tbGeneralSafetyLimit.Size = new System.Drawing.Size(148, 22);
            this.tbGeneralSafetyLimit.TabIndex = 4;
            this.tbGeneralSafetyLimit.TextChanged += new System.EventHandler(this.tbGeneralSafetyLimit_TextChanged);
            this.tbGeneralSafetyLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGeneralSafetyLimit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "General safety limit";
            // 
            // gbPipeline
            // 
            this.gbPipeline.Controls.Add(this.label5);
            this.gbPipeline.Controls.Add(this.tbPipeline);
            this.gbPipeline.Enabled = false;
            this.gbPipeline.Location = new System.Drawing.Point(834, 54);
            this.gbPipeline.Name = "gbPipeline";
            this.gbPipeline.Size = new System.Drawing.Size(165, 77);
            this.gbPipeline.TabIndex = 10;
            this.gbPipeline.TabStop = false;
            this.gbPipeline.Text = "Pipeline properties";
            this.gbPipeline.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Safety limit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbPipeline
            // 
            this.tbPipeline.Location = new System.Drawing.Point(7, 38);
            this.tbPipeline.Name = "tbPipeline";
            this.tbPipeline.Size = new System.Drawing.Size(152, 22);
            this.tbPipeline.TabIndex = 0;
            this.tbPipeline.TextChanged += new System.EventHandler(this.tbPipeline_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1011, 712);
            this.Controls.Add(this.gbPipeline);
            this.Controls.Add(this.networkProperties);
            this.Controls.Add(this.gbSetRate);
            this.Controls.Add(this.componentProperties);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.componentProperties.ResumeLayout(false);
            this.componentProperties.PerformLayout();
            this.gbSetRate.ResumeLayout(false);
            this.gbSetRate.PerformLayout();
            this.networkProperties.ResumeLayout(false);
            this.networkProperties.PerformLayout();
            this.gbPipeline.ResumeLayout(false);
            this.gbPipeline.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripButton btnPump;
        private System.Windows.Forms.ToolStripButton btnSink;
        private System.Windows.Forms.ToolStripButton btnSplitter;
        private System.Windows.Forms.ToolStripButton btnAdjSplitter;
        private System.Windows.Forms.ToolStripButton btnMerger;
        private System.Windows.Forms.ToolStripButton btnPipeline;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.GroupBox componentProperties;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFlow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSetRate;
        private System.Windows.Forms.TextBox tbSetRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnMove;
        private System.Windows.Forms.GroupBox networkProperties;
        private System.Windows.Forms.TextBox tbGeneralSafetyLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPipeline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPipeline;
    }
}

