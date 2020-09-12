using Switcher.Config;
using Switcher.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Environment = Switcher.Model.Environment;

namespace Switcher
{
    public partial class Main : Form
    {
        private readonly List<Project> _config = ConfigManager.Load();
        private Project _currentProject;
        private Environment _currentEnvi;
        private Item _currentItem;

        public Main()
        {
            InitializeComponent();

            this.projectListView.Data = _config.Select(p => p.Name);

            this.projectListView.SelectedDataChanged += ProjectListView_SelectedDataChanged;
            this.enviListView.SelectedDataChanged += EnviListView_SelectedDataChanged;
            this.fileListView.SelectedDataChanged += FileListView_SelectedDataChanged;

            this.projectListView.Added += (s, e) => this._config.Add(new Project(e.Value));
            this.projectListView.Updated += (s, e) => this._config[e.Index].Name = e.Value;
            this.projectListView.Deleted += (s, e) => this._config.RemoveAt(e.Index);
            this.projectListView.Save += (s, e) => ConfigManager.Save();

            this.enviListView.Added += EnviListView_Added;
            this.enviListView.Updated += EnviListView_Updated;
            this.enviListView.Deleted += EnviListView_Deleted;
            this.enviListView.Save += (s, e) => ConfigManager.Save();

            this.fileListView.Added += FileListView_Added;
            this.fileListView.Updated += FileListView_Updated;
            this.fileListView.Deleted += FileListView_Deleted;
            this.fileListView.Save += (s, e) => ConfigManager.Save();
        }

        private void FileListView_Deleted(object sender, Components.DataEventArgs e)
        {
            if (this._currentProject == null)
            {
                MessageBox.Show(this, "请选择项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this._currentEnvi.Items.RemoveAt(e.Index);
        }

        private void FileListView_Updated(object sender, Components.DataEventArgs e)
        {
            if (this._currentEnvi == null)
            {
                MessageBox.Show(this, "请选择环境", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this._currentEnvi.Items[e.Index].Name = e.Value;
        }

        private void FileListView_Added(object sender, Components.DataEventArgs e)
        {
            if (this._currentEnvi == null)
            {
                MessageBox.Show(this, "请选择环境", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this._currentEnvi.Items.Add(new Item(e.Value));
        }

        private void EnviListView_Deleted(object sender, Components.DataEventArgs e)
        {
            if (this._currentProject == null)
            {
                MessageBox.Show(this, "请选择项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this._currentProject.Environments.RemoveAt(e.Index);
        }

        private void EnviListView_Updated(object sender, Components.DataEventArgs e)
        {
            if (this._currentProject == null)
            {
                MessageBox.Show(this, "请选择项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this._currentProject.Environments[e.Index].Name = e.Value;
        }

        private void EnviListView_Added(object sender, Components.DataEventArgs e)
        {
            if (this._currentProject == null)
            {
                MessageBox.Show(this, "请选择项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this._currentProject.Environments.Add(new Environment(e.Value));
        }

        private void ProjectListView_SelectedDataChanged(object sender, Components.DataEventArgs e)
        {
            this._currentItem = null;
            this._currentEnvi = null;
            this.sourcePathTextBox.Text = null;
            this.targetPathTextBox.Text = null;
            this.fileTextBox.Text = null;
            this._currentProject = this._config.ElementAtOrDefault(e.Index);
            this.enviListView.Data = this._currentProject?.Environments.Select(p => p.Name);
            this.fileListView.Data = null;
        }


        private void EnviListView_SelectedDataChanged(object sender, Components.DataEventArgs e)
        {
            this._currentItem = null;
            this.sourcePathTextBox.Text = null;
            this.targetPathTextBox.Text = null;
            this.fileTextBox.Text = null;
            this._currentEnvi = this._currentProject?.Environments.ElementAtOrDefault(e.Index);
            this.fileListView.Data = this._currentEnvi?.Items.Select(p => p.Name);
        }


        private void FileListView_SelectedDataChanged(object sender, Components.DataEventArgs e)
        {
            this.sourcePathTextBox.Text = null;
            this.targetPathTextBox.Text = null;
            this.fileTextBox.Text = null;
            this._currentItem = this._currentEnvi?.Items.ElementAtOrDefault(e.Index);
            this.sourcePathTextBox.Text = this._currentItem?.SourcePath;
            this.targetPathTextBox.Text = this._currentItem?.TargetPath;
            if (File.Exists(this._currentItem?.SourcePath))
            {
                this.fileTextBox.Text = File.ReadAllText(this._currentItem.SourcePath);
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.sourcePathTextBox.Text))
                return;
            if(File.Exists(this.sourcePathTextBox.Text.Trim()))
            {
                this.fileTextBox.Text = File.ReadAllText(this.sourcePathTextBox.Text.Trim());
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this._currentItem == null)
            {
                MessageBox.Show(this, "请选择文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this._currentItem.SourcePath = this.sourcePathTextBox.Text.Trim();
            this._currentItem.TargetPath = this.targetPathTextBox.Text.Trim();
            ConfigManager.Save();
            if (!File.Exists(this._currentItem.SourcePath))
            {
                using (var fs = new FileStream(this._currentItem.SourcePath, FileMode.OpenOrCreate, FileAccess.Read))
                {

                }
            }

            File.WriteAllText(this._currentItem.SourcePath, this.fileTextBox.Text);
            MessageBox.Show(this, "保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
            this.notifyIcon1.Visible = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.项目ToolStripMenuItem.DropDownItems.Clear();
            foreach(var project in this._config)
            {
                var item = this.项目ToolStripMenuItem.DropDownItems.Add(project.Name) as ToolStripDropDownItem;
                item.Tag = project;
                foreach(var envi in project.Environments)
                {
                    var enviItem = item.DropDownItems.Add(envi.Name);
                    enviItem.Tag = envi;
                    enviItem.Click += EnviItem_Click;
                }
            }
        }

        private void EnviItem_Click(object sender, EventArgs e)
        {
            var tool = sender as ToolStripDropDownItem;
            if (tool == null)
                return;
            var envi = tool.Tag as Environment;
            if (envi == null)
                return;

            if (MessageBox.Show(this, $"确定要将当前项目切换到{envi.Name}环境吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            foreach(var item in envi.Items)
            {
                File.Copy(item.SourcePath, item.TargetPath, true);
            }

            MessageBox.Show(this, "切换成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
