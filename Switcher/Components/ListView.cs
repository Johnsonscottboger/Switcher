using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switcher.Components
{
    [ToolboxItem(true)]
    public partial class ListView : UserControl
    {
        private ModeType _mode;
        private int? _editRowIndex;
        private DataGridViewCell _cell;
        private List<string> _data = new List<string>();

        [Category("Other")]
        [DisplayName("Title")]
        public string Title
        {
            get => this.titleLabel.Text;
            set => this.titleLabel.Text = value;
        }

        public event EventHandler<DataEventArgs> SelectedDataChanged;

        public event EventHandler<DataEventArgs> Added;

        public event EventHandler<DataEventArgs> Updated;

        public event EventHandler<DataEventArgs> Deleted;

        public event EventHandler Save;

        public IEnumerable<string> Data
        {
            get => this._data;
            set
            {
                this._data.Clear();
                this.dataGridView.Rows.Clear();
                if (value == null)
                {
                    this._data = new List<string>();
                }
                else
                {
                    foreach (var item in value)
                    {
                        this._data.Add(item);
                        this.dataGridView.Rows.Add(item);
                    }
                }
            }
        }

        public ListView()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this._mode = ModeType.ADD;
            this.addButton.Enabled = false;
            this.editButton.Enabled = false;
            this.deleteButton.Enabled = false;
            this.saveButton.Enabled = true;

            var rowIndex = this.dataGridView.Rows.Add();
            this._cell = this.dataGridView[0, rowIndex];
            this._cell.ReadOnly = false;
            this.dataGridView.CurrentCell = this._cell;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this._mode = ModeType.EDIT;
            this.addButton.Enabled = false;
            this.editButton.Enabled = false;
            this.deleteButton.Enabled = false;
            this.saveButton.Enabled = true;

            this._cell = this.dataGridView.CurrentCell;
            this._cell.ReadOnly = false;
            this.dataGridView.BeginEdit(false);
            this._editRowIndex = this._cell.RowIndex;
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this._mode = ModeType.EDIT;
            this.addButton.Enabled = false;
            this.editButton.Enabled = false;
            this.deleteButton.Enabled = false;
            this.saveButton.Enabled = true;
            this._cell = this.dataGridView[e.ColumnIndex, e.RowIndex];
            this._editRowIndex = e.RowIndex;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this._mode = ModeType.NONE;
            var row = this.dataGridView.CurrentRow;
            if (row == null)
                return;
            var index = row.Index;
            this._data.RemoveAt(index);
            this.dataGridView.Rows.Remove(row);
            Deleted?.Invoke(this, new DataEventArgs(index, null));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this._cell == null)
                return;
            var value = this._cell.Value as string;
            switch (this._mode)
            {
                case ModeType.ADD:
                    {
                        this._data.Add(value);
                        Added?.Invoke(this, new DataEventArgs(this._data.Count - 1, value));
                        break;
                    }
                case ModeType.EDIT:
                    {
                        if (this._editRowIndex != null)
                        {
                            if (this._editRowIndex >= this._data.Count)
                            {
                                if(this._data.Contains(value))
                                {
                                    MessageBox.Show("重复的值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    this.dataGridView.BeginEdit(false);
                                    return;
                                }
                                this._data.Add(value);
                                Added?.Invoke(this, new DataEventArgs(this._editRowIndex.Value, value));
                            }
                            else
                            {
                                this._data[this._editRowIndex.Value] = value;
                                Updated?.Invoke(this, new DataEventArgs(this._editRowIndex.Value, value));
                            }
                        }
                        this.dataGridView.EndEdit();
                        break;
                    }
            }

            this.addButton.Enabled = true;
            this.editButton.Enabled = true;
            this.deleteButton.Enabled = true;
            this.saveButton.Enabled = false;

            Save?.Invoke(this, EventArgs.Empty);
        }

        private enum ModeType
        {
            NONE,
            ADD,
            EDIT
        }

        private void DataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            var currentCell = this.dataGridView.CurrentCell;
            if (currentCell == null)
                return;
            this.SelectedDataChanged?.Invoke(sender, new DataEventArgs(currentCell.RowIndex, currentCell.Value as string));
        }
    }

    public class DataEventArgs : EventArgs
    {
        public int Index { get; set; }

        public string Value { get; set; }

        public DataEventArgs()
        {

        }

        public DataEventArgs(int index, string value )
        {
            this.Index = index;
            this.Value = value;
        }
    }
}
