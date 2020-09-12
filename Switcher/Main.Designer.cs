namespace Switcher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.projectSplitContainer = new System.Windows.Forms.SplitContainer();
            this.enviSplitContainer = new System.Windows.Forms.SplitContainer();
            this.fileSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.sourcePathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.targetPathTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileTextBox = new System.Windows.Forms.RichTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第一个项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第一个环境ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectListView = new Switcher.Components.ListView();
            this.enviListView = new Switcher.Components.ListView();
            this.fileListView = new Switcher.Components.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.projectSplitContainer)).BeginInit();
            this.projectSplitContainer.Panel1.SuspendLayout();
            this.projectSplitContainer.Panel2.SuspendLayout();
            this.projectSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enviSplitContainer)).BeginInit();
            this.enviSplitContainer.Panel1.SuspendLayout();
            this.enviSplitContainer.Panel2.SuspendLayout();
            this.enviSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSplitContainer)).BeginInit();
            this.fileSplitContainer.Panel1.SuspendLayout();
            this.fileSplitContainer.Panel2.SuspendLayout();
            this.fileSplitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectSplitContainer
            // 
            this.projectSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.projectSplitContainer.Name = "projectSplitContainer";
            // 
            // projectSplitContainer.Panel1
            // 
            this.projectSplitContainer.Panel1.Controls.Add(this.projectListView);
            // 
            // projectSplitContainer.Panel2
            // 
            this.projectSplitContainer.Panel2.Controls.Add(this.enviSplitContainer);
            this.projectSplitContainer.Size = new System.Drawing.Size(1296, 595);
            this.projectSplitContainer.SplitterDistance = 304;
            this.projectSplitContainer.TabIndex = 0;
            // 
            // enviSplitContainer
            // 
            this.enviSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enviSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.enviSplitContainer.Name = "enviSplitContainer";
            // 
            // enviSplitContainer.Panel1
            // 
            this.enviSplitContainer.Panel1.Controls.Add(this.enviListView);
            // 
            // enviSplitContainer.Panel2
            // 
            this.enviSplitContainer.Panel2.Controls.Add(this.fileSplitContainer);
            this.enviSplitContainer.Size = new System.Drawing.Size(988, 595);
            this.enviSplitContainer.SplitterDistance = 219;
            this.enviSplitContainer.TabIndex = 0;
            // 
            // fileSplitContainer
            // 
            this.fileSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.fileSplitContainer.Name = "fileSplitContainer";
            // 
            // fileSplitContainer.Panel1
            // 
            this.fileSplitContainer.Panel1.Controls.Add(this.fileListView);
            // 
            // fileSplitContainer.Panel2
            // 
            this.fileSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.fileSplitContainer.Panel2.Controls.Add(this.panel2);
            this.fileSplitContainer.Size = new System.Drawing.Size(765, 595);
            this.fileSplitContainer.SplitterDistance = 158;
            this.fileSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.07634F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.92367F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.sourcePathTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.targetPathTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.openButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.53764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.46236F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 93);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.Location = new System.Drawing.Point(523, 50);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(71, 40);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "√";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // sourcePathTextBox
            // 
            this.sourcePathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourcePathTextBox.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcePathTextBox.Location = new System.Drawing.Point(81, 3);
            this.sourcePathTextBox.Multiline = true;
            this.sourcePathTextBox.Name = "sourcePathTextBox";
            this.sourcePathTextBox.Size = new System.Drawing.Size(436, 41);
            this.sourcePathTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "目标";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetPathTextBox
            // 
            this.targetPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetPathTextBox.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetPathTextBox.Location = new System.Drawing.Point(81, 50);
            this.targetPathTextBox.Multiline = true;
            this.targetPathTextBox.Name = "targetPathTextBox";
            this.targetPathTextBox.Size = new System.Drawing.Size(436, 40);
            this.targetPathTextBox.TabIndex = 2;
            // 
            // openButton
            // 
            this.openButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openButton.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openButton.Location = new System.Drawing.Point(523, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(71, 41);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "O";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.fileTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 496);
            this.panel2.TabIndex = 1;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTextBox.Location = new System.Drawing.Point(0, 0);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(600, 496);
            this.fileTextBox.TabIndex = 0;
            this.fileTextBox.Text = "";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Switcher";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.项目ToolStripMenuItem,
            this.toolStripSeparator1,
            this.打开ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 82);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // 项目ToolStripMenuItem
            // 
            this.项目ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.第一个项目ToolStripMenuItem});
            this.项目ToolStripMenuItem.Name = "项目ToolStripMenuItem";
            this.项目ToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.项目ToolStripMenuItem.Text = "项目";
            // 
            // 第一个项目ToolStripMenuItem
            // 
            this.第一个项目ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.第一个环境ToolStripMenuItem});
            this.第一个项目ToolStripMenuItem.Name = "第一个项目ToolStripMenuItem";
            this.第一个项目ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.第一个项目ToolStripMenuItem.Text = "第一个项目";
            // 
            // 第一个环境ToolStripMenuItem
            // 
            this.第一个环境ToolStripMenuItem.Name = "第一个环境ToolStripMenuItem";
            this.第一个环境ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.第一个环境ToolStripMenuItem.Text = "第一个环境";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // projectListView
            // 
            this.projectListView.Data = ((System.Collections.Generic.IEnumerable<string>)(resources.GetObject("projectListView.Data")));
            this.projectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectListView.Location = new System.Drawing.Point(0, 0);
            this.projectListView.Name = "projectListView";
            this.projectListView.Size = new System.Drawing.Size(304, 595);
            this.projectListView.TabIndex = 0;
            this.projectListView.Title = "项目";
            // 
            // enviListView
            // 
            this.enviListView.Data = ((System.Collections.Generic.IEnumerable<string>)(resources.GetObject("enviListView.Data")));
            this.enviListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enviListView.Location = new System.Drawing.Point(0, 0);
            this.enviListView.Name = "enviListView";
            this.enviListView.Size = new System.Drawing.Size(219, 595);
            this.enviListView.TabIndex = 0;
            this.enviListView.Title = "环境";
            // 
            // fileListView
            // 
            this.fileListView.Data = ((System.Collections.Generic.IEnumerable<string>)(resources.GetObject("fileListView.Data")));
            this.fileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListView.Location = new System.Drawing.Point(0, 0);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(158, 595);
            this.fileListView.TabIndex = 0;
            this.fileListView.Title = "配置";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 595);
            this.Controls.Add(this.projectSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.projectSplitContainer.Panel1.ResumeLayout(false);
            this.projectSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectSplitContainer)).EndInit();
            this.projectSplitContainer.ResumeLayout(false);
            this.enviSplitContainer.Panel1.ResumeLayout(false);
            this.enviSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enviSplitContainer)).EndInit();
            this.enviSplitContainer.ResumeLayout(false);
            this.fileSplitContainer.Panel1.ResumeLayout(false);
            this.fileSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSplitContainer)).EndInit();
            this.fileSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer projectSplitContainer;
        private System.Windows.Forms.SplitContainer enviSplitContainer;
        private System.Windows.Forms.SplitContainer fileSplitContainer;
        private Components.ListView projectListView;
        private Components.ListView enviListView;
        private Components.ListView fileListView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox sourcePathTextBox;
        private System.Windows.Forms.RichTextBox fileTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第一个项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第一个环境ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox targetPathTextBox;
        private System.Windows.Forms.Button openButton;
    }
}

