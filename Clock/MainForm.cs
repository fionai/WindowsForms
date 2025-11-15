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

		private void buttonHideControls_Click(object sender, EventArgs e)
		{
			checkBoxShowDate.Visible = false;
			checkBoxShowWeekday.Visible = false;

		}
	}
}
