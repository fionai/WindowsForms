namespace Clock
{
	partial class SetAlarm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetAlarm));
			this.labelAlarmTime1 = new System.Windows.Forms.Label();
			this.buttonAlarmAdd = new System.Windows.Forms.Button();
			this.buttonAlarmDelete1 = new System.Windows.Forms.Button();
			this.timerAlarm = new System.Windows.Forms.Timer(this.components);
			this.labelAlarmTime2 = new System.Windows.Forms.Label();
			this.labelAlarmTime3 = new System.Windows.Forms.Label();
			this.labelAlarmTime4 = new System.Windows.Forms.Label();
			this.buttonAlarmOK = new System.Windows.Forms.Button();
			this.buttonAlarmCancel = new System.Windows.Forms.Button();
			this.comboBoxAlarmMelody = new System.Windows.Forms.ComboBox();
			this.pickerSetAlarmTime = new System.Windows.Forms.DateTimePicker();
			this.pickerAlarmTime1 = new System.Windows.Forms.DateTimePicker();
			this.pickerAlarmTime2 = new System.Windows.Forms.DateTimePicker();
			this.pickerAlarmTime3 = new System.Windows.Forms.DateTimePicker();
			this.buttonAlarmStop = new System.Windows.Forms.Button();
			this.buttonAlarmDelete2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelAlarmTime1
			// 
			this.labelAlarmTime1.AutoSize = true;
			this.labelAlarmTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.labelAlarmTime1.Location = new System.Drawing.Point(14, 455);
			this.labelAlarmTime1.Name = "labelAlarmTime1";
			this.labelAlarmTime1.Size = new System.Drawing.Size(0, 73);
			this.labelAlarmTime1.TabIndex = 0;
			// 
			// buttonAlarmAdd
			// 
			this.buttonAlarmAdd.AutoEllipsis = true;
			this.buttonAlarmAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.buttonAlarmAdd.ForeColor = System.Drawing.Color.Red;
			this.buttonAlarmAdd.Location = new System.Drawing.Point(26, 15);
			this.buttonAlarmAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonAlarmAdd.Name = "buttonAlarmAdd";
			this.buttonAlarmAdd.Size = new System.Drawing.Size(75, 65);
			this.buttonAlarmAdd.TabIndex = 1;
			this.buttonAlarmAdd.Text = "+";
			this.buttonAlarmAdd.UseVisualStyleBackColor = true;
			this.buttonAlarmAdd.Click += new System.EventHandler(this.buttonAddAlarm_Click);
			// 
			// buttonAlarmDelete1
			// 
			this.buttonAlarmDelete1.AutoEllipsis = true;
			this.buttonAlarmDelete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonAlarmDelete1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlarmDelete1.Image")));
			this.buttonAlarmDelete1.Location = new System.Drawing.Point(295, 91);
			this.buttonAlarmDelete1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonAlarmDelete1.Name = "buttonAlarmDelete1";
			this.buttonAlarmDelete1.Size = new System.Drawing.Size(80, 80);
			this.buttonAlarmDelete1.TabIndex = 4;
			this.buttonAlarmDelete1.UseVisualStyleBackColor = true;
			this.buttonAlarmDelete1.Visible = false;
			this.buttonAlarmDelete1.Click += new System.EventHandler(this.buttonAlarmDelete1_Click);
			// 
			// timerAlarm
			// 
			this.timerAlarm.Enabled = true;
			this.timerAlarm.Interval = 80;
			this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
			// 
			// labelAlarmTime2
			// 
			this.labelAlarmTime2.AutoSize = true;
			this.labelAlarmTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.labelAlarmTime2.Location = new System.Drawing.Point(87, 455);
			this.labelAlarmTime2.Name = "labelAlarmTime2";
			this.labelAlarmTime2.Size = new System.Drawing.Size(0, 73);
			this.labelAlarmTime2.TabIndex = 9;
			this.labelAlarmTime2.Click += new System.EventHandler(this.labelAlarmTime2_Click);
			// 
			// labelAlarmTime3
			// 
			this.labelAlarmTime3.AutoSize = true;
			this.labelAlarmTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.labelAlarmTime3.Location = new System.Drawing.Point(158, 512);
			this.labelAlarmTime3.Name = "labelAlarmTime3";
			this.labelAlarmTime3.Size = new System.Drawing.Size(0, 73);
			this.labelAlarmTime3.TabIndex = 10;
			// 
			// labelAlarmTime4
			// 
			this.labelAlarmTime4.AutoSize = true;
			this.labelAlarmTime4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.labelAlarmTime4.Location = new System.Drawing.Point(367, 491);
			this.labelAlarmTime4.Name = "labelAlarmTime4";
			this.labelAlarmTime4.Size = new System.Drawing.Size(0, 73);
			this.labelAlarmTime4.TabIndex = 11;
			// 
			// buttonAlarmOK
			// 
			this.buttonAlarmOK.AutoEllipsis = true;
			this.buttonAlarmOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonAlarmOK.Location = new System.Drawing.Point(26, 398);
			this.buttonAlarmOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonAlarmOK.Name = "buttonAlarmOK";
			this.buttonAlarmOK.Size = new System.Drawing.Size(179, 65);
			this.buttonAlarmOK.TabIndex = 12;
			this.buttonAlarmOK.Text = "OK";
			this.buttonAlarmOK.UseVisualStyleBackColor = true;
			this.buttonAlarmOK.Visible = false;
			this.buttonAlarmOK.Click += new System.EventHandler(this.buttonAlarmOK_Click);
			// 
			// buttonAlarmCancel
			// 
			this.buttonAlarmCancel.AutoEllipsis = true;
			this.buttonAlarmCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonAlarmCancel.Location = new System.Drawing.Point(214, 398);
			this.buttonAlarmCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonAlarmCancel.Name = "buttonAlarmCancel";
			this.buttonAlarmCancel.Size = new System.Drawing.Size(178, 65);
			this.buttonAlarmCancel.TabIndex = 13;
			this.buttonAlarmCancel.Text = "Cancel";
			this.buttonAlarmCancel.UseVisualStyleBackColor = true;
			this.buttonAlarmCancel.Visible = false;
			this.buttonAlarmCancel.Click += new System.EventHandler(this.buttonAlarmCancel_Click);
			// 
			// comboBoxAlarmMelody
			// 
			this.comboBoxAlarmMelody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAlarmMelody.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.comboBoxAlarmMelody.FormattingEnabled = true;
			this.comboBoxAlarmMelody.Location = new System.Drawing.Point(25, 154);
			this.comboBoxAlarmMelody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBoxAlarmMelody.Name = "comboBoxAlarmMelody";
			this.comboBoxAlarmMelody.Size = new System.Drawing.Size(361, 45);
			this.comboBoxAlarmMelody.TabIndex = 14;
			this.comboBoxAlarmMelody.Visible = false;
			// 
			// pickerSetAlarmTime
			// 
			this.pickerSetAlarmTime.CustomFormat = "HH:mm";
			this.pickerSetAlarmTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.pickerSetAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerSetAlarmTime.Location = new System.Drawing.Point(26, 42);
			this.pickerSetAlarmTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pickerSetAlarmTime.Name = "pickerSetAlarmTime";
			this.pickerSetAlarmTime.Size = new System.Drawing.Size(252, 80);
			this.pickerSetAlarmTime.TabIndex = 16;
			this.pickerSetAlarmTime.Value = new System.DateTime(2025, 11, 23, 0, 0, 0, 0);
			this.pickerSetAlarmTime.Visible = false;
			// 
			// pickerAlarmTime1
			// 
			this.pickerAlarmTime1.CustomFormat = "HH:mm";
			this.pickerAlarmTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.pickerAlarmTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerAlarmTime1.Location = new System.Drawing.Point(26, 91);
			this.pickerAlarmTime1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pickerAlarmTime1.Name = "pickerAlarmTime1";
			this.pickerAlarmTime1.Size = new System.Drawing.Size(252, 80);
			this.pickerAlarmTime1.TabIndex = 17;
			this.pickerAlarmTime1.Value = new System.DateTime(2025, 11, 23, 0, 0, 0, 0);
			this.pickerAlarmTime1.Visible = false;
			// 
			// pickerAlarmTime2
			// 
			this.pickerAlarmTime2.CustomFormat = "HH:mm";
			this.pickerAlarmTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.pickerAlarmTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerAlarmTime2.Location = new System.Drawing.Point(26, 198);
			this.pickerAlarmTime2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pickerAlarmTime2.Name = "pickerAlarmTime2";
			this.pickerAlarmTime2.Size = new System.Drawing.Size(252, 80);
			this.pickerAlarmTime2.TabIndex = 18;
			this.pickerAlarmTime2.Value = new System.DateTime(2025, 11, 23, 0, 0, 0, 0);
			this.pickerAlarmTime2.Visible = false;
			// 
			// pickerAlarmTime3
			// 
			this.pickerAlarmTime3.CustomFormat = "HH:mm";
			this.pickerAlarmTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.pickerAlarmTime3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerAlarmTime3.Location = new System.Drawing.Point(26, 305);
			this.pickerAlarmTime3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pickerAlarmTime3.Name = "pickerAlarmTime3";
			this.pickerAlarmTime3.Size = new System.Drawing.Size(252, 80);
			this.pickerAlarmTime3.TabIndex = 19;
			this.pickerAlarmTime3.Value = new System.DateTime(2025, 11, 23, 0, 0, 0, 0);
			this.pickerAlarmTime3.Visible = false;
			// 
			// buttonAlarmStop
			// 
			this.buttonAlarmStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.buttonAlarmStop.Location = new System.Drawing.Point(26, 290);
			this.buttonAlarmStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonAlarmStop.Name = "buttonAlarmStop";
			this.buttonAlarmStop.Size = new System.Drawing.Size(359, 172);
			this.buttonAlarmStop.TabIndex = 20;
			this.buttonAlarmStop.Text = "STOP";
			this.buttonAlarmStop.UseVisualStyleBackColor = true;
			this.buttonAlarmStop.Visible = false;
			this.buttonAlarmStop.Click += new System.EventHandler(this.buttonAlarmStop_Click);
			// 
			// buttonAlarmDelete2
			// 
			this.buttonAlarmDelete2.AutoEllipsis = true;
			this.buttonAlarmDelete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonAlarmDelete2.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlarmDelete2.Image")));
			this.buttonAlarmDelete2.Location = new System.Drawing.Point(295, 198);
			this.buttonAlarmDelete2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonAlarmDelete2.Name = "buttonAlarmDelete2";
			this.buttonAlarmDelete2.Size = new System.Drawing.Size(80, 80);
			this.buttonAlarmDelete2.TabIndex = 21;
			this.buttonAlarmDelete2.UseVisualStyleBackColor = true;
			this.buttonAlarmDelete2.Visible = false;
			this.buttonAlarmDelete2.Click += new System.EventHandler(this.buttonAlarmDelete2_Click);
			// 
			// SetAlarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(404, 478);
			this.Controls.Add(this.buttonAlarmDelete2);
			this.Controls.Add(this.buttonAlarmStop);
			this.Controls.Add(this.pickerAlarmTime3);
			this.Controls.Add(this.pickerAlarmTime2);
			this.Controls.Add(this.pickerAlarmTime1);
			this.Controls.Add(this.pickerSetAlarmTime);
			this.Controls.Add(this.comboBoxAlarmMelody);
			this.Controls.Add(this.buttonAlarmCancel);
			this.Controls.Add(this.buttonAlarmOK);
			this.Controls.Add(this.labelAlarmTime4);
			this.Controls.Add(this.labelAlarmTime3);
			this.Controls.Add(this.labelAlarmTime2);
			this.Controls.Add(this.buttonAlarmDelete1);
			this.Controls.Add(this.buttonAlarmAdd);
			this.Controls.Add(this.labelAlarmTime1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SetAlarm";
			this.Text = "Alarm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAlarmTime1;
		private System.Windows.Forms.Button buttonAlarmAdd;
		private System.Windows.Forms.Button buttonAlarmDelete1;
		private System.Windows.Forms.Label labelAlarmTime2;
		private System.Windows.Forms.Label labelAlarmTime3;
		private System.Windows.Forms.Label labelAlarmTime4;
		private System.Windows.Forms.Button buttonAlarmOK;
		private System.Windows.Forms.Button buttonAlarmCancel;
		private System.Windows.Forms.ComboBox comboBoxAlarmMelody;
		private System.Windows.Forms.DateTimePicker pickerSetAlarmTime;
		private System.Windows.Forms.DateTimePicker pickerAlarmTime1;
		private System.Windows.Forms.DateTimePicker pickerAlarmTime2;
		private System.Windows.Forms.DateTimePicker pickerAlarmTime3;
		private System.Windows.Forms.Button buttonAlarmStop;
		private System.Windows.Forms.Timer timerAlarm;
		private System.Windows.Forms.Button buttonAlarmDelete2;
	}
}