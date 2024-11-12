using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemotePlayTogetherSync
{
	public partial class FrmSettings : Form
	{
		public FrmSettings()
		{
			InitializeComponent();

			chkDebug.Checked = Properties.Settings.Default.EnableDebugLogs;
			chkUnlockAll.Checked = Properties.Settings.Default.UnlockAllAchievements;
		}

		private void chkDebug_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.EnableDebugLogs = chkDebug.Checked;
			Properties.Settings.Default.Save();
		}

		private void chkUnlockAll_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.UnlockAllAchievements = chkUnlockAll.Checked;
			Properties.Settings.Default.Save();
		}
	}
}
