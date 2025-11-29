namespace Clock
{
	partial class AlarmsForm
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
			this.lbAlarmList = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDeletye = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbAlarmList
			// 
			this.lbAlarmList.FormattingEnabled = true;
			this.lbAlarmList.ItemHeight = 24;
			this.lbAlarmList.Location = new System.Drawing.Point(13, 67);
			this.lbAlarmList.Name = "lbAlarmList";
			this.lbAlarmList.Size = new System.Drawing.Size(555, 316);
			this.lbAlarmList.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(614, 67);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(134, 59);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDeletye
			// 
			this.btnDeletye.Location = new System.Drawing.Point(614, 145);
			this.btnDeletye.Name = "btnDeletye";
			this.btnDeletye.Size = new System.Drawing.Size(134, 53);
			this.btnDeletye.TabIndex = 2;
			this.btnDeletye.Text = "Delete";
			this.btnDeletye.UseVisualStyleBackColor = true;
			// 
			// AlarmsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(937, 612);
			this.Controls.Add(this.btnDeletye);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lbAlarmList);
			this.Name = "AlarmsForm";
			this.ShowInTaskbar = false;
			this.Text = "AlarmsForm";
			this.Load += new System.EventHandler(this.AlarmsForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbAlarmList;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDeletye;
	}
}