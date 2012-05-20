﻿namespace VisualBounds.Imaging.PaintBucket
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.ribbonIcons = new System.Windows.Forms.ImageList(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.stripTools = new System.Windows.Forms.ToolStrip();
            this.btnToolOpen = new System.Windows.Forms.ToolStripButton();
            this.btnToolSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImageScale = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stripMenu = new System.Windows.Forms.ToolStrip();
            this.btnFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.scrollControl = new System.Windows.Forms.ScrollableControl();
            this.Preview = new System.Windows.Forms.PictureBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.stripStatus = new System.Windows.Forms.ToolStrip();
            this.barProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblReady = new System.Windows.Forms.ToolStripLabel();
            this.lblPosY = new System.Windows.Forms.ToolStripLabel();
            this.lblPosSep = new System.Windows.Forms.ToolStripLabel();
            this.lblPosX = new System.Windows.Forms.ToolStripLabel();
            this.lblPos = new System.Windows.Forms.ToolStripLabel();
            this.btnColor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.headerPanel.SuspendLayout();
            this.stripTools.SuspendLayout();
            this.stripMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.scrollControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.stripStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            this.colorDialog.ShowHelp = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Images|*.bmp;*.gif;*.jpeg;*.jpg;*.png;*.tiff|Bitmap|*.bmp|Graphical Interchan" +
    "ge Format|*.gif|JPEG|*.jpeg;*.jpg|Portable Network Graphic|*.png|Tagged Image Fi" +
    "le Format|*.tiff";
            this.openFileDialog.Title = "Paint Bucket - Open Image";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = resources.GetString("saveFileDialog.Filter");
            this.saveFileDialog.Title = "Paint Bucket - Save Image";
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "1337428682_emblem-photos.ico");
            this.Icons.Images.SetKeyName(1, "1337444930_insert-image.ico");
            this.Icons.Images.SetKeyName(2, "1337446435_gtk-leave-fullscreen.ico");
            // 
            // ribbonIcons
            // 
            this.ribbonIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ribbonIcons.ImageStream")));
            this.ribbonIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ribbonIcons.Images.SetKeyName(0, "fileopen_32x32x32.png");
            this.ribbonIcons.Images.SetKeyName(1, "filesave_32x32x32.png");
            this.ribbonIcons.Images.SetKeyName(2, "filesave_red_32x32x32.png");
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.panel4);
            this.headerPanel.Controls.Add(this.stripTools);
            this.headerPanel.Controls.Add(this.panel3);
            this.headerPanel.Controls.Add(this.stripMenu);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(890, 47);
            this.headerPanel.TabIndex = 4;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(891, 10);
            this.panel4.TabIndex = 11;
            // 
            // stripTools
            // 
            this.stripTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stripTools.AutoSize = false;
            this.stripTools.BackColor = System.Drawing.Color.Transparent;
            this.stripTools.Dock = System.Windows.Forms.DockStyle.None;
            this.stripTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.stripTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolOpen,
            this.btnToolSave,
            this.toolStripSeparator2,
            this.btnImageScale,
            this.toolStripSeparator3,
            this.btnColor,
            this.toolStripSeparator4});
            this.stripTools.Location = new System.Drawing.Point(2, 22);
            this.stripTools.Name = "stripTools";
            this.stripTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.stripTools.Size = new System.Drawing.Size(889, 25);
            this.stripTools.TabIndex = 9;
            this.stripTools.Text = "toolStrip1";
            this.stripTools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stripBars_MouseDown);
            // 
            // btnToolOpen
            // 
            this.btnToolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolOpen.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.folder_explore;
            this.btnToolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolOpen.Name = "btnToolOpen";
            this.btnToolOpen.Size = new System.Drawing.Size(23, 22);
            this.btnToolOpen.Text = "Open";
            this.btnToolOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnToolSave
            // 
            this.btnToolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolSave.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.disk;
            this.btnToolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolSave.Name = "btnToolSave";
            this.btnToolSave.Size = new System.Drawing.Size(23, 22);
            this.btnToolSave.Text = "Save";
            this.btnToolSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnImageScale
            // 
            this.btnImageScale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImageScale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.btnImageScale.Image = ((System.Drawing.Image)(resources.GetObject("btnImageScale.Image")));
            this.btnImageScale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImageScale.Name = "btnImageScale";
            this.btnImageScale.Size = new System.Drawing.Size(51, 22);
            this.btnImageScale.Text = "100%";
            this.btnImageScale.ToolTipText = "Image Scale";
            this.btnImageScale.ButtonClick += new System.EventHandler(this.btnImageScale_ButtonClick);
            this.btnImageScale.MouseEnter += new System.EventHandler(this.btnImageScale_MouseEnter);
            this.btnImageScale.MouseLeave += new System.EventHandler(this.btnImageScale_MouseLeave);
            this.btnImageScale.TextChanged += new System.EventHandler(this.btnImageScale_TextChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem2.Text = "25%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem3.Text = "50%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem4.Text = "100%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem5.Text = "150%";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem6.Text = "200%";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem7.Text = "300%";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem8.Text = "500%";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(-17, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 21);
            this.panel3.TabIndex = 10;
            // 
            // stripMenu
            // 
            this.stripMenu.BackColor = System.Drawing.Color.Transparent;
            this.stripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.stripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile});
            this.stripMenu.Location = new System.Drawing.Point(0, 0);
            this.stripMenu.Name = "stripMenu";
            this.stripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.stripMenu.Size = new System.Drawing.Size(890, 25);
            this.stripMenu.TabIndex = 12;
            this.stripMenu.Text = "toolStrip2";
            this.stripMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stripBars_MouseDown);
            // 
            // btnFile
            // 
            this.btnFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnExit});
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(38, 22);
            this.btnFile.Text = "File";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.folder_explore;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(103, 22);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.disk;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.door_open;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.scrollControl);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 47);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(890, 449);
            this.panelMain.TabIndex = 5;
            // 
            // scrollControl
            // 
            this.scrollControl.AutoScroll = true;
            this.scrollControl.Controls.Add(this.Preview);
            this.scrollControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollControl.Location = new System.Drawing.Point(0, 0);
            this.scrollControl.Name = "scrollControl";
            this.scrollControl.Size = new System.Drawing.Size(890, 449);
            this.scrollControl.TabIndex = 1;
            this.scrollControl.Text = "scrollableControl1";
            // 
            // Preview
            // 
            this.Preview.BackColor = System.Drawing.Color.Transparent;
            this.Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Preview.Location = new System.Drawing.Point(0, 0);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(0, 0);
            this.Preview.TabIndex = 0;
            this.Preview.TabStop = false;
            this.Preview.MouseLeave += new System.EventHandler(this.image_MouseLeave);
            this.Preview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image_MouseMove);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.stripStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 496);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(890, 23);
            this.panelStatus.TabIndex = 6;
            // 
            // stripStatus
            // 
            this.stripStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stripStatus.AutoSize = false;
            this.stripStatus.BackColor = System.Drawing.Color.Transparent;
            this.stripStatus.Dock = System.Windows.Forms.DockStyle.None;
            this.stripStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.stripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barProgress,
            this.lblReady,
            this.lblPosY,
            this.lblPosSep,
            this.lblPosX,
            this.lblPos});
            this.stripStatus.Location = new System.Drawing.Point(0, 1);
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(892, 24);
            this.stripStatus.TabIndex = 0;
            this.stripStatus.Text = "toolStrip3";
            this.stripStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stripBars_MouseDown);
            // 
            // barProgress
            // 
            this.barProgress.AutoSize = false;
            this.barProgress.Name = "barProgress";
            this.barProgress.Size = new System.Drawing.Size(100, 15);
            // 
            // lblReady
            // 
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(48, 21);
            this.lblReady.Text = "Ready...";
            // 
            // lblPosY
            // 
            this.lblPosY.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(13, 21);
            this.lblPosY.Text = "0";
            this.lblPosY.ToolTipText = "Y Position";
            // 
            // lblPosSep
            // 
            this.lblPosSep.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPosSep.Name = "lblPosSep";
            this.lblPosSep.Size = new System.Drawing.Size(10, 21);
            this.lblPosSep.Text = ",";
            this.lblPosSep.ToolTipText = "Position relative to the image";
            // 
            // lblPosX
            // 
            this.lblPosX.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(13, 21);
            this.lblPosX.Text = "0";
            this.lblPosX.ToolTipText = "X Position";
            // 
            // lblPos
            // 
            this.lblPos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPos.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.chart_empty;
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(16, 21);
            this.lblPos.ToolTipText = "Position relative to the image";
            // 
            // btnColor
            // 
            this.btnColor.AutoSize = false;
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(22, 22);
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 519);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panelStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Paint Bucket";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.Deactivate += new System.EventHandler(this.FrmMain_Deactivate);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.stripTools.ResumeLayout(false);
            this.stripTools.PerformLayout();
            this.stripMenu.ResumeLayout(false);
            this.stripMenu.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.scrollControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.stripStatus.ResumeLayout(false);
            this.stripStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.ImageList ribbonIcons;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.ToolStrip stripTools;
        private System.Windows.Forms.ToolStripButton btnToolOpen;
        private System.Windows.Forms.ToolStripButton btnToolSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ScrollableControl scrollControl;
        private System.Windows.Forms.PictureBox Preview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip stripMenu;
        private System.Windows.Forms.ToolStripDropDownButton btnFile;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.ToolStrip stripStatus;
        private System.Windows.Forms.ToolStripProgressBar barProgress;
        private System.Windows.Forms.ToolStripLabel lblReady;
        private System.Windows.Forms.ToolStripLabel lblPosition;
        private System.Windows.Forms.ToolStripLabel lblPosY;
        private System.Windows.Forms.ToolStripLabel lblPosSep;
        private System.Windows.Forms.ToolStripLabel lblPosX;
        private System.Windows.Forms.ToolStripLabel lblPos;
        private System.Windows.Forms.ToolStripSplitButton btnImageScale;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel btnColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;



    }
}
