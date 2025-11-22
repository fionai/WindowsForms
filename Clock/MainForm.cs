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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			SetVisibility(false);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			//labelTime.Text = DateTime.Now.ToString("HH:mm:ss"); //24-час
			labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", 
				System.Globalization.CultureInfo.InvariantCulture); //12-час AM-PM
			if (checkBoxShowDate.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			}
			if (checkBoxShowWeekday.Checked)
			{ 
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			}
		}
		void SetVisibility (bool visible)
		{
			checkBoxShowDate.Visible = visible;
			checkBoxShowWeekday.Visible = visible;
			buttonHideControls.Visible = visible;
			this.FormBorderStyle = visible?  FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
			ShowInTaskbar = visible;
		}
		private void buttonHideControls_Click(object sender, EventArgs e) =>
			SetVisibility(tsmiShowControls.Checked = false);

		private void labelTime_DoubleClick(object sender, EventArgs e) =>
			SetVisibility(tsmiShowControls.Checked = true);

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			this.TopMost = true;
			this.TopMost = false;

		}

		private void tsmiQuit_Click(object sender, EventArgs e) =>
			this.Close();	

		private void tsmiTopmost_Click(object sender, EventArgs e) =>
			this.TopMost = tsmiTopmost.Checked;

		private void tsmiShowDate_Click(object sender, EventArgs e) =>
			checkBoxShowDate.Checked = tsmiShowDate.Checked;

		private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e) =>
			tsmiShowDate.Checked = checkBoxShowDate.Checked;

		private void tsmiShowWeekday_Click(object sender, EventArgs e) =>
			checkBoxShowWeekday.Checked = tsmiShowWeekday.Checked;

		private void checkBoxShowWeekday_CheckedChanged(object sender, EventArgs e) =>
			tsmiShowWeekday.Checked = (sender as CheckBox).Checked;

		private void tsmiShowControls_Click(object sender, EventArgs e) =>
			SetVisibility(tsmiShowControls.Checked);

		private void labelTime_Click(object sender, EventArgs e)
		{

		}

		private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
		{

		}

		private void tsmiForegroundColor_Click(object sender, EventArgs e)
		{
			if (labelTime.ForeColor == Color.Black)
				labelTime.ForeColor = Color.Aquamarine;
			else
				labelTime.ForeColor = Color.Black;
		}

		private void tsmiBackgroundColor_Click(object sender, EventArgs e)
		{
			if (labelTime.BackColor != Color.White)
				labelTime.BackColor = Color.White;
			else labelTime.BackColor = Color.Azure;
		}
	}
}
