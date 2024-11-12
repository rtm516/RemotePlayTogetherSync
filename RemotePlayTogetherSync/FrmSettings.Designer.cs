namespace RemotePlayTogetherSync
{
	partial class FrmSettings
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
			chkDebug = new CheckBox();
			chkUnlockAll = new CheckBox();
			numInterval = new NumericUpDown();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
			SuspendLayout();
			// 
			// chkDebug
			// 
			chkDebug.AutoSize = true;
			chkDebug.Location = new Point(12, 12);
			chkDebug.Name = "chkDebug";
			chkDebug.Size = new Size(124, 19);
			chkDebug.TabIndex = 0;
			chkDebug.Text = "Enable Debug logs";
			chkDebug.UseVisualStyleBackColor = true;
			chkDebug.CheckedChanged += chkDebug_CheckedChanged;
			// 
			// chkUnlockAll
			// 
			chkUnlockAll.AutoSize = true;
			chkUnlockAll.Location = new Point(12, 37);
			chkUnlockAll.Name = "chkUnlockAll";
			chkUnlockAll.Size = new Size(222, 19);
			chkUnlockAll.TabIndex = 1;
			chkUnlockAll.Text = "Unlock all achievements not just new";
			chkUnlockAll.UseVisualStyleBackColor = true;
			chkUnlockAll.CheckedChanged += chkUnlockAll_CheckedChanged;
			// 
			// numInterval
			// 
			numInterval.Increment = new decimal(new int[] { 10, 0, 0, 0 });
			numInterval.Location = new Point(12, 62);
			numInterval.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
			numInterval.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
			numInterval.Name = "numInterval";
			numInterval.Size = new Size(54, 23);
			numInterval.TabIndex = 2;
			numInterval.Value = new decimal(new int[] { 20, 0, 0, 0 });
			numInterval.ValueChanged += numInterval_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(72, 64);
			label1.Name = "label1";
			label1.Size = new Size(141, 15);
			label1.TabIndex = 3;
			label1.Text = "Update interval (seconds)";
			// 
			// FrmSettings
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(284, 97);
			Controls.Add(label1);
			Controls.Add(numInterval);
			Controls.Add(chkUnlockAll);
			Controls.Add(chkDebug);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FrmSettings";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Settings";
			((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox chkDebug;
		private CheckBox chkUnlockAll;
		private NumericUpDown numInterval;
		private Label label1;
	}
}