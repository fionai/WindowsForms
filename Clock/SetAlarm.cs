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

			//string pickerName = $"pickerAlarmTime{numericAlarms+1}";
			//string buttonDeleteName = $"buttonAlarmDelete{numericAlarms + 1}";
			if (numericAlarms < 1)
			{
				pickerAlarmTime1.Visible = true;
				buttonAlarmDelete1.Visible = true;
				pickerAlarmTime1.Value = pickerSetAlarmTime.Value;
				//melody[numericAlarms] = $"{Application.ExecutablePath}\\..\\..\\..\\Melody\\{comboBoxAlarmMelody.SelectedItem.ToString()}";
				//melody[numericAlarms] = comboBoxAlarmMelody.SelectedItem.ToString();


				isActualAlarms[numericAlarms] = 1;
				numericAlarms++;
			}

			if (numericAlarms == 1) 
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
			if (numericAlarms > 0)
			{
				numericAlarms--;
				buttonAlarmAdd.Visible = true;
				pickerAlarmTime1.Visible = false;
				buttonAlarmDelete1.Visible = false;
			}
		}

		private void timerAlarm_Tick(object sender, EventArgs e)
		{
			//if (DateTime.Now == pickerAlarmTime1.Value)
			if (!isPlaying && DateTime.Now.Hour == pickerAlarmTime1.Value.Hour && DateTime.Now.Minute == pickerAlarmTime1.Value.Minute)
			{
				////SoundPlayer alarmMelody = new SoundPlayer($"{Application.ExecutablePath}\\..\\..\\..\\Melody\\{melody[numericAlarms]}");
				//SoundPlayer alarmMelody = new SoundPlayer("C:\\Users\\Ada\\source\\repos\\WindowsForms\\Clock\\melody\\school.mp3");
				//alarmMelody.Play();

				m = new WMPLib.WindowsMediaPlayer();
				m.URL = "C:\\Users\\Ada\\source\\repos\\WindowsForms\\Clock\\melody\\school.mp3";
				m.controls.play();
				isPlaying = true;

				buttonAlarmStop.Visible = true;
				buttonAlarmDelete1.Visible = false;
				pickerAlarmTime1.Visible = false;
				//pickerAlarmTime1.Value = null;

				numericAlarms--;
				isActualAlarms[numericAlarms] = 0;
				buttonAlarmAdd.Visible = true;
			}
			else if (DateTime.Now.Hour != pickerAlarmTime1.Value.Hour || DateTime.Now.Minute != pickerAlarmTime1.Value.Minute)

			{
				isPlaying = false;
				buttonAlarmStop.Visible = false;
			}
		}

		private void buttonAlarmStop_Click(object sender, EventArgs e)
		{
			//isPlaying = false;
			m.close();
			buttonAlarmStop.Visible = false;
		}
	}
}
