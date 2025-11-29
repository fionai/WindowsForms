namespace Clock
{
	partial class AddAlarmForm
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
			this.cbUseDate = new System.Windows.Forms.CheckBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.dtpTime = new System.Windows.Forms.DateTimePicker();
			this.clbWeekDays = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// cbUseDate
			// 
			this.cbUseDate.AutoSize = true;
			this.cbUseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.cbUseDate.Location = new System.Drawing.Point(13, 13);
			this.cbUseDate.Name = "cbUseDate";
			this.cbUseDate.Size = new System.Drawing.Size(324, 42);
			this.cbUseDate.TabIndex = 0;
			this.cbUseDate.Text = "on the specific date";
			this.cbUseDate.UseVisualStyleBackColor = true;
			// 
			// dtpDate
			// 
			this.dtpDate.CustomFormat = "yyyy.MM.dd";
			this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(13, 89);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(272, 50);
			this.dtpDate.TabIndex = 1;
			// 
			// dtpTime
			// 
			this.dtpTime.CustomFormat = "hh:mm:ss";
			this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTime.Location = new System.Drawing.Point(291, 89);
			this.dtpTime.Name = "dtpTime";
			this.dtpTime.Size = new System.Drawing.Size(272, 50);
			this.dtpTime.TabIndex = 2;
			// 
			// clbWeekDays
			// 
			this.clbWeekDays.ColumnWidth = 58;
			this.clbWeekDays.FormattingEnabled = true;
			this.clbWeekDays.IntegralHeight = false;
			this.clbWeekDays.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
			this.clbWeekDays.Location = new System.Drawing.Point(13, 145);
			this.clbWeekDays.MultiColumn = true;
			this.clbWeekDays.Name = "clbWeekDays";
			this.clbWeekDays.Size = new System.Drawing.Size(707, 30);
			this.clbWeekDays.TabIndex = 3;
			// 
			// AddAlarmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 487);
			this.Controls.Add(this.clbWeekDays);
			this.Controls.Add(this.dtpTime);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.cbUseDate);
			this.Name = "AddAlarmForm";
			this.Text = "AddAlarmForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbUseDate;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.DateTimePicker dtpTime;
		private System.Windows.Forms.CheckedListBox clbWeekDays;
	}
}