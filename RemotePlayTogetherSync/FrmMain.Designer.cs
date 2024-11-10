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
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// cboWindow
			// 
			cboWindow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cboWindow.Enabled = false;
			cboWindow.FormattingEnabled = true;
			cboWindow.Location = new Point(13, 12);
			cboWindow.Margin = new Padding(4, 3, 4, 3);
			cboWindow.Name = "cboWindow";
			cboWindow.Size = new Size(319, 23);
			cboWindow.TabIndex = 0;
			toolTip.SetToolTip(cboWindow, "Windows");
			// 
			// btnWindowRefresh
			// 
			btnWindowRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnWindowRefresh.Enabled = false;
			btnWindowRefresh.Image = Properties.Resources.Refresh;
			btnWindowRefresh.Location = new Point(340, 12);
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
			btnWindowAuto.Location = new Point(371, 12);
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
			btnWindow.Location = new Point(13, 41);
			btnWindow.Margin = new Padding(4, 3, 4, 3);
			btnWindow.Name = "btnWindow";
			btnWindow.Size = new Size(381, 27);
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
			cboFriend.Location = new Point(13, 74);
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
			btnFriendRefresh.Location = new Point(340, 74);
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
			btnFriendAuto.Location = new Point(371, 74);
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
			btnFriend.Location = new Point(13, 103);
			btnFriend.Margin = new Padding(4, 3, 4, 3);
			btnFriend.Name = "btnFriend";
			btnFriend.Size = new Size(381, 27);
			btnFriend.TabIndex = 7;
			btnFriend.Text = "Start Syncing";
			btnFriend.UseVisualStyleBackColor = true;
			btnFriend.Click += btnFriend_Click;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(txtLogs);
			groupBox1.Location = new Point(13, 136);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(381, 371);
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
			txtLogs.Size = new Size(373, 349);
			txtLogs.TabIndex = 0;
			// 
			// FrmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(407, 519);
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
			MinimumSize = new Size(400, 558);
			Name = "FrmMain";
			Text = "Remote Play Together Achievements Sync";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
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
	}
}

