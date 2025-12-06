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
			this.components = new System.ComponentModel.Container();
			this.lbAlarmList = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDeletye = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lbAlarmList
			// 
			this.lbAlarmList.FormattingEnabled = true;
			this.lbAlarmList.ItemHeight = 20;
			this.lbAlarmList.Location = new System.Drawing.Point(11, 56);
			this.lbAlarmList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.lbAlarmList.Name = "lbAlarmList";
			this.lbAlarmList.Size = new System.Drawing.Size(455, 264);
			this.lbAlarmList.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(502, 56);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(110, 49);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDeletye
			// 
			this.btnDeletye.Location = new System.Drawing.Point(502, 121);
			this.btnDeletye.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDeletye.Name = "btnDeletye";
			this.btnDeletye.Size = new System.Drawing.Size(110, 44);
			this.btnDeletye.TabIndex = 2;
			this.btnDeletye.Text = "Delete";
			this.btnDeletye.UseVisualStyleBackColor = true;
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// AlarmsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 510);
			this.Controls.Add(this.btnDeletye);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lbAlarmList);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
		private System.Windows.Forms.Timer timer;
	}
}