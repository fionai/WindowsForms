using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Clock
{
	public partial class MainForm : Form
	{
		ColorDialog backgroundDialog;
		ColorDialog foregroundDialog;
		ChooseFont fontDialog;
		AlarmsForm alarms;
		public MainForm()
		{
			InitializeComponent();
			SetVisibility(false);
			backgroundDialog = new ColorDialog();
			foregroundDialog = new ColorDialog();
			fontDialog = new ChooseFont();
			alarms = new AlarmsForm(this);
			this.Location = new Point(
			Screen.PrimaryScreen.Bounds.Width - this.labelTime.Width - 200,
			50
			);
			tsmiTopmost.Checked = this.TopMost = true;
			//AllocConsole();
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
			notifyIcon.Text = labelTime.Text;
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

		private void tsmiBackgroundColor_Click(object sender, EventArgs e)
		{
			if (backgroundDialog.ShowDialog() == DialogResult.OK)
				labelTime.BackColor = backgroundDialog.Color;

		}

		private void tsmiForegroundColor_Click(object sender, EventArgs e)
		{
			if (foregroundDialog.ShowDialog() == DialogResult.OK)
				labelTime.ForeColor = foregroundDialog.Color;
		}
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();

		private void tsmiShowConsole_CheckedChanged(object sender, EventArgs e)
		{
			bool console = (sender as ToolStripMenuItem).Checked ? AllocConsole() : FreeConsole();
		}

		private void tsmiChooseFont_Click(object sender, EventArgs e)
		{
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				labelTime.Font = fontDialog.Font;
			}
		}

		private void tsmiAlarms_Click(object sender, EventArgs e)
		{
			alarms.ShowDialog(this);
		}
	}
}
