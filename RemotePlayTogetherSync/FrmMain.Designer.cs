namespace RemotePlayTogetherSync
{
	partial class FrmMain
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			cboWindow = new ComboBox();
			btnWindowRefresh = new Button();
			btnWindowAuto = new Button();
			btnWindow = new Button();
			cboFriend = new ComboBox();
			btnFriendRefresh = new Button();
			btnFriendAuto = new Button();
			btnFriend = new Button();
			groupBox1 = new GroupBox();
			txtLogs = new TextBox();
			toolTip = new ToolTip(components);
			btnWindowManual = new Button();
			toolStrip1 = new ToolStrip();
			toolStripDropDownButton1 = new ToolStripDropDownButton();
			toolBtnSettings = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			toolBtnExit = new ToolStripMenuItem();
			toolBtnHelp = new ToolStripButton();
			btnStop = new Button();
			groupBox1.SuspendLayout();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// cboWindow
			// 
			cboWindow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cboWindow.Enabled = false;
			cboWindow.FormattingEnabled = true;
			cboWindow.Location = new Point(13, 28);
			cboWindow.Margin = new Padding(4, 3, 4, 3);
			cboWindow.Name = "cboWindow";
			cboWindow.Size = new Size(288, 23);
			cboWindow.TabIndex = 0;
			toolTip.SetToolTip(cboWindow, "Windows");
			// 
			// btnWindowRefresh
			// 
			btnWindowRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnWindowRefresh.Enabled = false;
			btnWindowRefresh.Image = Properties.Resources.Refresh;
			btnWindowRefresh.Location = new Point(340, 28);
			btnWindowRefresh.Margin = new Padding(4, 3, 4, 3);
			btnWindowRefresh.Name = "btnWindowRefresh";
			btnWindowRefresh.Size = new Size(23, 23);
			btnWindowRefresh.TabIndex = 1;
			toolTip.SetToolTip(btnWindowRefresh, "Refresh Windows");
			btnWindowRefresh.UseVisualStyleBackColor = true;
			btnWindowRefresh.Click += btnWindowRefresh_Click;
			// 
			// btnWindowAuto
			// 
			btnWindowAuto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnWindowAuto.Enabled = false;
			btnWindowAuto.Image = Properties.Resources.Search;
			btnWindowAuto.Location = new Point(371, 28);
			btnWindowAuto.Margin = new Padding(4, 3, 4, 3);
			btnWindowAuto.Name = "btnWindowAuto";
			btnWindowAuto.Size = new Size(23, 23);
			btnWindowAuto.TabIndex = 2;
			toolTip.SetToolTip(btnWindowAuto, "Auto-Detect Window");
			btnWindowAuto.UseVisualStyleBackColor = true;
			btnWindowAuto.Click += btnWindowAuto_Click;
			// 
			// btnWindow
			// 
			btnWindow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnWindow.Enabled = false;
			btnWindow.Location = new Point(13, 57);
			btnWindow.Margin = new Padding(4, 3, 4, 3);
			btnWindow.Name = "btnWindow";
			btnWindow.Size = new Size(381, 23);
			btnWindow.TabIndex = 3;
			btnWindow.Text = "Set Game";
			btnWindow.UseVisualStyleBackColor = true;
			btnWindow.Click += btnWindow_Click;
			// 
			// cboFriend
			// 
			cboFriend.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cboFriend.Enabled = false;
			cboFriend.FormattingEnabled = true;
			cboFriend.Location = new Point(13, 86);
			cboFriend.Margin = new Padding(4, 3, 4, 3);
			cboFriend.Name = "cboFriend";
			cboFriend.Size = new Size(319, 23);
			cboFriend.TabIndex = 4;
			toolTip.SetToolTip(cboFriend, "Friends");
			// 
			// btnFriendRefresh
			// 
			btnFriendRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnFriendRefresh.Enabled = false;
			btnFriendRefresh.Image = Properties.Resources.Refresh;
			btnFriendRefresh.Location = new Point(340, 86);
			btnFriendRefresh.Margin = new Padding(4, 3, 4, 3);
			btnFriendRefresh.Name = "btnFriendRefresh";
			btnFriendRefresh.Size = new Size(23, 23);
			btnFriendRefresh.TabIndex = 5;
			toolTip.SetToolTip(btnFriendRefresh, "Refresh Friends");
			btnFriendRefresh.UseVisualStyleBackColor = true;
			// 
			// btnFriendAuto
			// 
			btnFriendAuto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnFriendAuto.Enabled = false;
			btnFriendAuto.Image = Properties.Resources.Search;
			btnFriendAuto.Location = new Point(371, 86);
			btnFriendAuto.Margin = new Padding(4, 3, 4, 3);
			btnFriendAuto.Name = "btnFriendAuto";
			btnFriendAuto.Size = new Size(23, 23);
			btnFriendAuto.TabIndex = 6;
			toolTip.SetToolTip(btnFriendAuto, "Auto-Detect Friend");
			btnFriendAuto.UseVisualStyleBackColor = true;
			btnFriendAuto.Click += btnFriendAuto_Click;
			// 
			// btnFriend
			// 
			btnFriend.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnFriend.Enabled = false;
			btnFriend.Location = new Point(13, 115);
			btnFriend.Margin = new Padding(4, 3, 4, 3);
			btnFriend.Name = "btnFriend";
			btnFriend.Size = new Size(289, 23);
			btnFriend.TabIndex = 7;
			btnFriend.Text = "Start Syncing";
			btnFriend.UseVisualStyleBackColor = true;
			btnFriend.Click += btnFriend_Click;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(txtLogs);
			groupBox1.Location = new Point(13, 144);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(381, 363);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Logs";
			// 
			// txtLogs
			// 
			txtLogs.BackColor = Color.Black;
			txtLogs.Dock = DockStyle.Fill;
			txtLogs.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtLogs.ForeColor = Color.White;
			txtLogs.Location = new Point(4, 19);
			txtLogs.Multiline = true;
			txtLogs.Name = "txtLogs";
			txtLogs.ReadOnly = true;
			txtLogs.ScrollBars = ScrollBars.Vertical;
			txtLogs.Size = new Size(373, 341);
			txtLogs.TabIndex = 0;
			// 
			// btnWindowManual
			// 
			btnWindowManual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnWindowManual.Enabled = false;
			btnWindowManual.Image = Properties.Resources.Input;
			btnWindowManual.Location = new Point(309, 28);
			btnWindowManual.Margin = new Padding(4, 3, 4, 3);
			btnWindowManual.Name = "btnWindowManual";
			btnWindowManual.Size = new Size(23, 23);
			btnWindowManual.TabIndex = 10;
			toolTip.SetToolTip(btnWindowManual, "Manual input");
			btnWindowManual.UseVisualStyleBackColor = true;
			btnWindowManual.Click += btnWindowManual_Click;
			// 
			// toolStrip1
			// 
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolBtnHelp });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(407, 25);
			toolStrip1.TabIndex = 9;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolBtnSettings, toolStripSeparator1, toolBtnExit });
			toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			toolStripDropDownButton1.Size = new Size(38, 22);
			toolStripDropDownButton1.Text = "&File";
			// 
			// toolBtnSettings
			// 
			toolBtnSettings.Name = "toolBtnSettings";
			toolBtnSettings.Size = new Size(116, 22);
			toolBtnSettings.Text = "&Settings";
			toolBtnSettings.Click += toolBtnSettings_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(113, 6);
			// 
			// toolBtnExit
			// 
			toolBtnExit.Name = "toolBtnExit";
			toolBtnExit.Size = new Size(116, 22);
			toolBtnExit.Text = "&Exit";
			toolBtnExit.Click += toolBtnExit_Click;
			// 
			// toolBtnHelp
			// 
			toolBtnHelp.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolBtnHelp.ImageTransparentColor = Color.Magenta;
			toolBtnHelp.Name = "toolBtnHelp";
			toolBtnHelp.Size = new Size(36, 22);
			toolBtnHelp.Text = "&Help";
			toolBtnHelp.Click += toolBtnHelp_Click;
			// 
			// btnStop
			// 
			btnStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnStop.Enabled = false;
			btnStop.Location = new Point(309, 115);
			btnStop.Name = "btnStop";
			btnStop.Size = new Size(86, 23);
			btnStop.TabIndex = 11;
			btnStop.Text = "Stop/Reset";
			btnStop.UseVisualStyleBackColor = true;
			btnStop.Click += btnStop_Click;
			// 
			// FrmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(407, 519);
			Controls.Add(btnStop);
			Controls.Add(btnWindowManual);
			Controls.Add(toolStrip1);
			Controls.Add(groupBox1);
			Controls.Add(btnFriend);
			Controls.Add(btnFriendAuto);
			Controls.Add(btnFriendRefresh);
			Controls.Add(cboFriend);
			Controls.Add(btnWindow);
			Controls.Add(btnWindowAuto);
			Controls.Add(btnWindowRefresh);
			Controls.Add(cboWindow);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MinimumSize = new Size(423, 558);
			Name = "FrmMain";
			Text = "Remote Play Together Achievements Sync";
			Load += FrmMain_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ComboBox cboWindow;
		private System.Windows.Forms.Button btnWindowRefresh;
		private System.Windows.Forms.Button btnWindowAuto;
		private System.Windows.Forms.Button btnWindow;
		private System.Windows.Forms.ComboBox cboFriend;
		private System.Windows.Forms.Button btnFriendRefresh;
		private System.Windows.Forms.Button btnFriendAuto;
		private System.Windows.Forms.Button btnFriend;
		private System.Windows.Forms.GroupBox groupBox1;
		private TextBox txtLogs;
		private ToolTip toolTip;
		private ToolStrip toolStrip1;
		private ToolStripDropDownButton toolStripDropDownButton1;
		private ToolStripButton toolBtnHelp;
		private ToolStripMenuItem toolBtnSettings;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem toolBtnExit;
		private Button btnWindowManual;
		private Button btnStop;
	}
}

