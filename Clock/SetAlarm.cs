using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class SetAlarm : Form
	{
		int numericAlarms = 0;
		public string[] melody = {"", "", ""};
		string alarmFileName = "C:\\Users\\Ada\\source\\repos\\WindowsForms\\Clock\\melody\\school.mp3";
		bool isPlaying = false;
		int[] isActualAlarms = { 0, 0, 0 };
		WMPLib.WindowsMediaPlayer m;

		public SetAlarm()
		{
			InitializeComponent();
			LoadMelodies();
			comboBoxAlarmMelody.SelectedIndex = 0;
		}
		void LoadMelodies()
		{
			string directory = $"{Application.ExecutablePath}\\..\\..\\..\\Melody";
			Directory.SetCurrentDirectory(directory);
			comboBoxAlarmMelody.Items.AddRange(GetFilesByExt(Directory.GetCurrentDirectory(), "*.*"));

		}
		string[] GetFilesByExt(string directory, string format)
		{
			string[] files = Directory.GetFiles(directory, format);
			for (int i = 0; i < files.Length; i++)
			{
				files[i] = files[i].Split('\\').Last();
				//files[i] = files[i].Split('.').First();
			}
			return files;
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void labelAlarmTime2_Click(object sender, EventArgs e)
		{

		}

		private void buttonAddAlarm_Click(object sender, EventArgs e)
		{
			pickerSetAlarmTime.Visible = true;
			pickerAlarmTime1.Visible = false;
			buttonAlarmDelete1.Visible = false;
			pickerAlarmTime2.Visible = false;
			pickerAlarmTime3.Visible = false;
			comboBoxAlarmMelody.Visible = true;
			buttonAlarmOK.Visible = true;
			buttonAlarmCancel.Visible = true;
			buttonAlarmAdd.Visible = false;
		}

		private void buttonAlarmOK_Click(object sender, EventArgs e)
		{
			pickerSetAlarmTime.Visible=false;
			comboBoxAlarmMelody.Visible = false;
			buttonAlarmOK.Visible = false;
			buttonAlarmCancel.Visible = false;
			buttonAlarmAdd.Visible = true;

			if (numericAlarms == 0)
			{
				pickerAlarmTime1.Visible = true;
				buttonAlarmDelete1.Visible = true;
				pickerAlarmTime1.Value = pickerSetAlarmTime.Value;

				////получаем путь к мелодии
				melody[numericAlarms] = Application.ExecutablePath;
				melody[numericAlarms] = melody[numericAlarms].Remove(melody[numericAlarms].IndexOf("bin\\"));
				melody[numericAlarms] += "melody\\";
				melody[numericAlarms] += comboBoxAlarmMelody.SelectedItem.ToString();


				isActualAlarms[numericAlarms] = 1;
				numericAlarms++;
			}
			else if (numericAlarms == 1)
			{
				pickerAlarmTime1.Visible = true;
				buttonAlarmDelete1.Visible = true;
				pickerAlarmTime2.Visible = true;
				buttonAlarmDelete2.Visible = true;
				pickerAlarmTime2.Value = pickerSetAlarmTime.Value;

				////получаем путь к мелодии
				melody[numericAlarms] = Application.ExecutablePath;
				melody[numericAlarms] = melody[numericAlarms].Remove(melody[numericAlarms].IndexOf("bin\\"));
				melody[numericAlarms] += "melody\\";
				melody[numericAlarms] += comboBoxAlarmMelody.SelectedItem.ToString();


				isActualAlarms[numericAlarms] = 1;
				numericAlarms++;
			}

			if (numericAlarms == 2) 
				buttonAlarmAdd.Visible = false;
		}

		private void buttonAlarmCancel_Click(object sender, EventArgs e)
		{
			pickerSetAlarmTime.Visible=false;
			comboBoxAlarmMelody.Visible = false;
			buttonAlarmOK.Visible = false;
			buttonAlarmCancel.Visible = false;
			buttonAlarmAdd.Visible = true;
			if (numericAlarms > 0)
				pickerAlarmTime1.Visible = true;
		}

		private void textBoxAlarmHours_TextChanged(object sender, EventArgs e)
		{
			
		}


		private void buttonAlarmDelete1_Click(object sender, EventArgs e)
		{
			if (numericAlarms == 1)
			{
				numericAlarms--;
				pickerAlarmTime1.Visible = false;
				buttonAlarmDelete1.Visible = false;
			}
			else if (numericAlarms == 2)
			{
				numericAlarms--;
				buttonAlarmAdd.Visible = true;
				pickerAlarmTime2.Visible = false;
				buttonAlarmDelete2.Visible = false;
				pickerAlarmTime1.Value = pickerAlarmTime2.Value;
			}
		}

		private void timerAlarm_Tick(object sender, EventArgs e)
		{
			if (!isPlaying && DateTime.Now.Hour == pickerAlarmTime1.Value.Hour && DateTime.Now.Minute == pickerAlarmTime1.Value.Minute)
			{
				m = new WMPLib.WindowsMediaPlayer();

				m.URL = melody[0];
				m.controls.play();
				isPlaying = true;

				buttonAlarmStop.Visible = true;
				buttonAlarmDelete1.Visible = false;
				pickerAlarmTime1.Visible = false;

				numericAlarms--;
				isActualAlarms[0] = 0;
				buttonAlarmAdd.Visible = true;
			}
			else if (numericAlarms == 0 && ( DateTime.Now.Hour != pickerAlarmTime1.Value.Hour || DateTime.Now.Minute != pickerAlarmTime1.Value.Minute))

			{
				isPlaying = false;
				buttonAlarmStop.Visible = false;
			}


			if (!isPlaying && DateTime.Now.Hour == pickerAlarmTime2.Value.Hour && DateTime.Now.Minute == pickerAlarmTime2.Value.Minute)
			{
				m = new WMPLib.WindowsMediaPlayer();

				m.URL = melody[1];
				m.controls.play();
				isPlaying = true;

				buttonAlarmStop.Visible = true;
				buttonAlarmDelete2.Visible = false;
				pickerAlarmTime2.Visible = false;
				//pickerAlarmTime1.Value = null;

				numericAlarms--;
				isActualAlarms[1] = 0;
				buttonAlarmAdd.Visible = true;
			}
			else if (numericAlarms == 1 && ( DateTime.Now.Hour != pickerAlarmTime2.Value.Hour || DateTime.Now.Minute != pickerAlarmTime2.Value.Minute))
			{
				isPlaying = false;
				buttonAlarmStop.Visible = false;
			}
		}

		private void buttonAlarmStop_Click(object sender, EventArgs e)
		{
			m.close();
			buttonAlarmStop.Visible = false;
		}

		private void buttonAlarmDelete2_Click(object sender, EventArgs e)
		{
			numericAlarms--;
			buttonAlarmAdd.Visible = true;
			pickerAlarmTime2.Visible = false;
			buttonAlarmDelete2.Visible = false;
		}
	}
}
