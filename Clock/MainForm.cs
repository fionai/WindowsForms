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
using System.IO;
using System.Reflection;


namespace Clock
{
	public partial class MainForm : Form
	{
		ColorDialog backgroundDialog;
		ColorDialog foregroundDialog;
		ChooseFont fontDialog;
		SetAlarm setAlarm;
		public MainForm()
		{
			InitializeComponent();
			SetVisibility(false);
			backgroundDialog = new ColorDialog();
			foregroundDialog = new ColorDialog();
			fontDialog = new ChooseFont();
			setAlarm = new SetAlarm();
			this.Location = new Point(
			Screen.PrimaryScreen.Bounds.Width - this.labelTime.Width - 150,
			50
			);

			string iniPath = Application.ExecutablePath;
			iniPath = iniPath.Remove(iniPath.IndexOf("bin\\"));
			string iniFile = iniPath + "settings_clock.ini";

			StreamReader sr = new StreamReader(iniFile);

			//TopMost
			this.TopMost = true;
			string currentString = sr.ReadLine();
			currentString = currentString.Remove(0, 8);
			if (currentString == "0")
				TopMost = false;
			else if (currentString == "1")
				TopMost = true;

			//Show_date
			checkBoxShowDate.Checked = tsmiShowDate.Checked = false;
			currentString = sr.ReadLine();
			currentString = currentString.Remove(0, 10);
			if (currentString == "0")
				checkBoxShowDate.Checked = tsmiShowDate.Checked = false;
			else if (currentString == "1")
				checkBoxShowDate.Checked = tsmiShowDate.Checked = true;

			//Weekday
			checkBoxShowWeekday.Checked = tsmiShowWeekday.Checked = false;
			currentString = sr.ReadLine();
			currentString = currentString.Remove(0, 13);
			if (currentString == "0")
				checkBoxShowWeekday.Checked = tsmiShowWeekday.Checked = false;
			else if (currentString == "1")
				checkBoxShowWeekday.Checked = tsmiShowWeekday.Checked = true;

			//font
			//пока не буду
			currentString = sr.ReadLine();
			

			//color_f
			//пока не буду
			currentString = sr.ReadLine();



			//color_b
			//пока не буду
			currentString = sr.ReadLine();

			//alarms_num 
			int alarms_num = 0;
			currentString = sr.ReadLine();
			currentString = currentString.Remove(0, 11);
			//if (currentString == "0" || currentString == "")
			if (currentString == "1")
			{
				alarms_num++;

				//alarm1_hh
				currentString = sr.ReadLine();
				currentString = currentString.Remove(0, 10);
				int hh = int.Parse(currentString);

				//alarm1_mm
				currentString = sr.ReadLine();
				currentString = currentString.Remove(0, 10);
				int mm = int.Parse(currentString);


				//alarm1_music
				currentString = sr.ReadLine();
				currentString = currentString.Remove(0, 13);
				string melodyPath = iniPath + "melody\\" + currentString;
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString("HH:mm:ss"); //24-час
			//labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", 
			//	System.Globalization.CultureInfo.InvariantCulture); //12-час AM-PM
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

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			//SetVisibility(tsmiShowControls.Checked = true);
			SetVisibility(tsmiShowControls.Checked = !tsmiShowControls.Checked);
		}

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

		private void tsmiSetAlarm_Click(object sender, EventArgs e)
		{
			setAlarm.ShowDialog();
		}

		private void labelTime_Click(object sender, EventArgs e)
		{

		}
	}
}
