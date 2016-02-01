namespace EventStudio
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectExplorer = new System.Windows.Forms.TabControl();
            this.tabProjectExplorer = new System.Windows.Forms.TabPage();
            this.tabEventExplorer = new System.Windows.Forms.TabPage();
            this.treeViewProject = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.saveProject = new System.Windows.Forms.SaveFileDialog();
            this.treeEventView = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.ProjectExplorer.SuspendLayout();
            this.tabProjectExplorer.SuspendLayout();
            this.tabEventExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1211, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "UpMenuStrip";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMenuItem,
            this.LoadMenuItem,
            this.SaveMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(35, 20);
            this.FileMenuItem.Text = "File";
            // 
            // CreateMenuItem
            // 
            this.CreateMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProjectMenuItem});
            this.CreateMenuItem.Name = "CreateMenuItem";
            this.CreateMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CreateMenuItem.Text = "Create";
            // 
            // LoadMenuItem
            // 
            this.LoadMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProjectMenuItem});
            this.LoadMenuItem.Name = "LoadMenuItem";
            this.LoadMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LoadMenuItem.Text = "Load";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveProjectMenuItem});
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveMenuItem.Text = "Save";
            // 
            // createProjectMenuItem
            // 
            this.createProjectMenuItem.Name = "createProjectMenuItem";
            this.createProjectMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createProjectMenuItem.Text = "Create Project";
            this.createProjectMenuItem.Click += new System.EventHandler(this.createProjectMenuItem_Click);
            // 
            // loadProjectMenuItem
            // 
            this.loadProjectMenuItem.Name = "loadProjectMenuItem";
            this.loadProjectMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadProjectMenuItem.Text = "Load Project";
            // 
            // saveProjectMenuItem
            // 
            this.saveProjectMenuItem.Name = "saveProjectMenuItem";
            this.saveProjectMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveProjectMenuItem.Text = "Save Project";
            // 
            // ProjectExplorer
            // 
            this.ProjectExplorer.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.ProjectExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectExplorer.Controls.Add(this.tabProjectExplorer);
            this.ProjectExplorer.Controls.Add(this.tabEventExplorer);
            this.ProjectExplorer.Location = new System.Drawing.Point(0, 0);
            this.ProjectExplorer.Name = "ProjectExplorer";
            this.ProjectExplorer.SelectedIndex = 0;
            this.ProjectExplorer.Size = new System.Drawing.Size(159, 279);
            this.ProjectExplorer.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.ProjectExplorer.TabIndex = 1;
            // 
            // tabProjectExplorer
            // 
            this.tabProjectExplorer.Controls.Add(this.treeViewProject);
            this.tabProjectExplorer.Location = new System.Drawing.Point(4, 4);
            this.tabProjectExplorer.Margin = new System.Windows.Forms.Padding(0);
            this.tabProjectExplorer.Name = "tabProjectExplorer";
            this.tabProjectExplorer.Size = new System.Drawing.Size(151, 253);
            this.tabProjectExplorer.TabIndex = 0;
            this.tabProjectExplorer.Text = "Project Explorer";
            this.tabProjectExplorer.UseVisualStyleBackColor = true;
            // 
            // tabEventExplorer
            // 
            this.tabEventExplorer.Controls.Add(this.treeEventView);
            this.tabEventExplorer.Location = new System.Drawing.Point(4, 4);
            this.tabEventExplorer.Name = "tabEventExplorer";
            this.tabEventExplorer.Padding = new System.Windows.Forms.Padding(3);
            this.tabEventExplorer.Size = new System.Drawing.Size(151, 253);
            this.tabEventExplorer.TabIndex = 1;
            this.tabEventExplorer.Text = "Event Explorer";
            this.tabEventExplorer.UseVisualStyleBackColor = true;
            // 
            // treeViewProject
            // 
            this.treeViewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewProject.Location = new System.Drawing.Point(0, 0);
            this.treeViewProject.Name = "treeViewProject";
            this.treeViewProject.Size = new System.Drawing.Size(151, 253);
            this.treeViewProject.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1211, 517);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ProjectExplorer);
            this.splitContainer2.Size = new System.Drawing.Size(162, 517);
            this.splitContainer2.SplitterDistance = 282;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeEventView
            // 
            this.treeEventView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeEventView.Location = new System.Drawing.Point(0, 0);
            this.treeEventView.Name = "treeEventView";
            this.treeEventView.Size = new System.Drawing.Size(151, 253);
            this.treeEventView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 541);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProjectExplorer.ResumeLayout(false);
            this.tabProjectExplorer.ResumeLayout(false);
            this.tabEventExplorer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectMenuItem;
        private System.Windows.Forms.TabControl ProjectExplorer;
        private System.Windows.Forms.TabPage tabProjectExplorer;
        private System.Windows.Forms.TreeView treeViewProject;
        private System.Windows.Forms.TabPage tabEventExplorer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SaveFileDialog saveProject;
        private System.Windows.Forms.TreeView treeEventView;
    }
}

