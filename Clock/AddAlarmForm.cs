using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AddAlarmForm : Form
	{
		Form parent;
		OpenFileDialog fileDialog;
		public AddAlarmForm()
		{
			InitializeComponent();
			dtpDate.Enabled = cbUseDate.Checked;
			fileDialog = new OpenFileDialog();
			fileDialog.Filter = "All files|*.mp3;*.flacc|MP-3 file (*.mp3)|*.mp3|Flacc files (*.flacc)|*.flacc";
		}
		public AddAlarmForm(Form parent):this()
		{
			this.parent = parent;
			this.StartPosition = FormStartPosition.Manual;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{

		}

		private void cbUseDate_CheckedChanged(object sender, EventArgs e)
		{
			dtpDate.Enabled = cbUseDate.Checked;
		}

		private void btnFile_Click(object sender, EventArgs e)
		{
			fileDialog.ShowDialog();
			lblFile.Text = fileDialog.FileName;
		}

		private void AddAlarmForm_Load(object sender, EventArgs e)
		{
			this.Location = new Point(parent.Location.X+25, parent.Location.Y+20);
		}
	}
}
