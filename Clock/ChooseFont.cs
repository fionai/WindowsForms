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
using System.IO;
using System.Drawing.Text;


namespace Clock
{
	public partial class ChooseFont : Form
	{
		new public Font Font {  get; set; }
		public ChooseFont()
		{
			InitializeComponent();
			LoadFonts();
		}
		void LoadFonts()
		{
			Console.WriteLine(Application.ExecutablePath);
			Console.WriteLine(Directory.GetCurrentDirectory());
			Console.WriteLine(Directory.GetParent(Application.ExecutablePath).FullName);
			string directory = $"{Application.ExecutablePath}\\..\\..\\..\\Fonts";
			Directory.SetCurrentDirectory(directory);
			Console.WriteLine(Directory.GetCurrentDirectory());
			////////////////////////////////////////////////////////////////
			comboBoxFont.Items.AddRange(GetFilesByExt(Directory.GetCurrentDirectory(), "*.ttf"));
			comboBoxFont.Items.AddRange(GetFilesByExt(Directory.GetCurrentDirectory(), "*.otf"));
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

		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.Font = labelExample.Font;
		}

		private void ChooseFont_Load(object sender, EventArgs e)
		{
			//LoadFonts();
			//Console.WriteLine(Application.ExecutablePath);
			//Console.WriteLine(Directory.GetCurrentDirectory());
			//Console.WriteLine(Directory.GetParent(Application.ExecutablePath).FullName);
			//string directory = $"{Application.ExecutablePath}\\..\\..\\..\\Fonts";
			//Directory.SetCurrentDirectory(directory);
			//Console.WriteLine(Directory.GetCurrentDirectory());
		}

		private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Console.WriteLine("\nSelectedIndexChanged: \n");
			//Console.WriteLine($"Selected index:\t{ (sender as ComboBox).SelectedIndex}");
			//Console.WriteLine($"Selected index:\t{ (sender as ComboBox).SelectedItem}");
			//Console.WriteLine($"Selected index:\t{ (sender as ComboBox).SelectedText.ToString()}");
			//Console.WriteLine($"Selected index:\t{ (sender as ComboBox).SelectedValue.ToString()}");
			//Console.WriteLine("\n--------------------------------\n");
			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile((sender as ComboBox).SelectedItem.ToString());
			labelExample.Font = new Font( pfc.Families[0], 32);
		}
	}
}
