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
	public partial class AlarmsForm : Form
	{
		Form parent;
		public AlarmsForm()
		{
			InitializeComponent();
			//Console.WriteLine(this.Parent.Location.X);

		}
		public AlarmsForm(Form parent) : this()
		{
			this.parent = parent;	//parent должен быть с маленькой буквы.
			this.StartPosition = FormStartPosition.Manual;

		}
		private void btnAdd_Click(object sender, EventArgs e)
		{

			AddAlarmForm alarmDialog = new AddAlarmForm(this);
			if(alarmDialog.ShowDialog() == DialogResult.OK)
			{
				lbAlarmList.Items.Add(alarmDialog.Alarm);
			}

		}

		private void AlarmsForm_Load(object sender, EventArgs e)
		{
			this.Location = new Point(parent.Location.X-50, parent.Location.Y+150);
			this.TopMost = true;
			this.TopMost = false;
		}
	}
}
