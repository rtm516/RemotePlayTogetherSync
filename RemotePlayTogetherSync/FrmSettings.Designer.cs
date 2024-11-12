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
			// FrmSettings
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(284, 68);
			Controls.Add(chkUnlockAll);
			Controls.Add(chkDebug);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FrmSettings";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Settings";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox chkDebug;
		private CheckBox chkUnlockAll;
	}
}