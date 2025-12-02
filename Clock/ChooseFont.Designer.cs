namespace Clock
{
	partial class ChooseFont
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
			this.comboBoxFont = new System.Windows.Forms.ComboBox();
			this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
			this.labelExample = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxFont
			// 
			this.comboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.comboBoxFont.FormattingEnabled = true;
			this.comboBoxFont.Location = new System.Drawing.Point(14, 48);
			this.comboBoxFont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBoxFont.Name = "comboBoxFont";
			this.comboBoxFont.Size = new System.Drawing.Size(673, 45);
			this.comboBoxFont.TabIndex = 0;
			this.comboBoxFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxFont_SelectedIndexChanged);
			// 
			// numericUpDownFontSize
			// 
			this.numericUpDownFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.numericUpDownFontSize.Location = new System.Drawing.Point(738, 48);
			this.numericUpDownFontSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numericUpDownFontSize.Name = "numericUpDownFontSize";
			this.numericUpDownFontSize.Size = new System.Drawing.Size(135, 44);
			this.numericUpDownFontSize.TabIndex = 1;
			this.numericUpDownFontSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.numericUpDownFontSize.ValueChanged += new System.EventHandler(this.numericUpDownFontSize_ValueChanged);
			// 
			// labelExample
			// 
			this.labelExample.AutoSize = true;
			this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.labelExample.Location = new System.Drawing.Point(15, 165);
			this.labelExample.Name = "labelExample";
			this.labelExample.Size = new System.Drawing.Size(282, 73);
			this.labelExample.TabIndex = 2;
			this.labelExample.Text = "Example";
			this.labelExample.Click += new System.EventHandler(this.labelExample_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonOK.Location = new System.Drawing.Point(520, 489);
			this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(182, 59);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonCancel.Location = new System.Drawing.Point(709, 489);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(178, 59);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// ChooseFont
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 562);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.numericUpDownFontSize);
			this.Controls.Add(this.comboBoxFont);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ChooseFont";
			this.Text = "ChooseFont";
			this.Load += new System.EventHandler(this.ChooseFont_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxFont;
		private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
		private System.Windows.Forms.Label labelExample;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}