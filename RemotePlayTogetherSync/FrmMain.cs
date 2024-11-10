using Steamworks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RemotePlayTogetherSync
{
	public partial class FrmMain : Form
	{
		List<SteamAppList.App> appList;
		Worker remotePlaySync;

		public FrmMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Utils.GetSteamInstallPath()) == true)
			{
				MessageBox.Show("Failed to get Steam install path");
				Application.Exit();
				return;
			}

			Logs.SetTextBox(txtLogs);

			Logs.Info($"Loading Steam apps...");
			Task.Run(() =>
			{
				try
				{
					using (WebClient webClient = new WebClient())
					{
						webClient.Encoding = Encoding.UTF8;
						string json = webClient.DownloadString("https://api.steampowered.com/ISteamApps/GetAppList/v2/");
						appList = JsonSerializer.Deserialize<SteamAppList>(json).List.Apps;

						// Remove 753 from the list, as its steam its self
						appList.RemoveAll(app => app.Id == 753);
					}
				}
				catch (Exception e)
				{
					Logs.Error($"Failed to load Steam apps: {e.Message}");
					Logs.Error($"Please restart the application");
					return;
				}

				// Enable the UI
				Invoke(() =>
				{
					btnWindow.Enabled = true;
					btnWindowAuto.Enabled = true;
					btnWindowRefresh.Enabled = true;
					cboWindow.Enabled = true;
				});

				Logs.Info($"Loaded {Utils.Format(appList.Count)} apps");
			});

			RefreshWindowList();
		}

		private List<string> GetWindowTitles()
		{
			List<string> titles = new();
			Process[] processlist = Process.GetProcesses();
			foreach (Process process in processlist)
			{
				if (!String.IsNullOrEmpty(process.MainWindowTitle))
				{
					titles.Add(process.MainWindowTitle);
				}
			}
			return titles;
		}

		private void btnWindowAuto_Click(object sender, EventArgs e)
		{
			List<string> titles = GetWindowTitles();
			SteamAppList.App foundApp = null;
			foreach (string title in titles)
			{
				foundApp = appList.FirstOrDefault(app => title.Equals(app.Name));
				if (foundApp != null)
				{
					break;
				}
			}

			if (foundApp == null)
			{
				MessageBox.Show("No app found");
				return;
			}

			RefreshWindowList();
			cboWindow.SelectedItem = foundApp.Name;
		}

		private void RefreshWindowList()
		{
			// Re-populate the list
			cboWindow.Items.Clear();
			cboWindow.Items.AddRange(GetWindowTitles().ToArray());

			Utils.FixSelectedItem(cboWindow);
		}

		private void btnWindowRefresh_Click(object sender, EventArgs e)
		{
			RefreshWindowList();
		}

		private void btnWindow_Click(object sender, EventArgs e)
		{
			SteamAppList.App foundApp = appList.FirstOrDefault(app => cboWindow.SelectedItem.Equals(app.Name));
			//SteamAppList.App foundApp = appList.FirstOrDefault(app => app.Id.Equals(267530));

			if (foundApp == null)
			{
				MessageBox.Show($"No app found with given name '{cboWindow.SelectedItem}'");
				return;
			}

			remotePlaySync = new(foundApp);

			RefreshFriendsList();

			btnWindow.Enabled = false;
			btnWindowAuto.Enabled = false;
			btnWindowRefresh.Enabled = false;
			cboWindow.Enabled = false;

			btnFriend.Enabled = true;
			btnFriendAuto.Enabled = true;
			btnFriendRefresh.Enabled = true;
			cboFriend.Enabled = true;
		}

		private void RefreshFriendsList()
		{
			cboFriend.Items.Clear();
			var friends = remotePlaySync.GetFriends()
				.Select(friend => $"{friend.Name} - {friend.Id}").ToArray();
			cboFriend.Items.AddRange(friends);

			Utils.FixSelectedItem(cboFriend);
		}

		private void btnFriend_Click(object sender, EventArgs e)
		{
			IEnumerable<Friend> friends = remotePlaySync.GetFriends().Where(friend => $"{friend.Name} - {friend.Id}".Equals(cboFriend.SelectedItem));
			if (friends.Count() != 1)
			{
				MessageBox.Show("No friend found");
				return;
			}

			btnFriend.Enabled = false;
			btnFriendAuto.Enabled = false;
			btnFriendRefresh.Enabled = false;
			cboFriend.Enabled = false;

			remotePlaySync.Start(friends.First());
		}

		private void btnFriendAuto_Click(object sender, EventArgs e)
		{
			IEnumerable<Friend> friends = remotePlaySync.GetFriends().Where(friend => friend.IsPlayingThisGame);
			if (friends.Count() > 1)
			{
				MessageBox.Show("More than 1 friend found playing your selected game");
				return;
			}

			if (friends.Count() == 0)
			{
				MessageBox.Show("No friend found playing your selected game");
				return;
			}

			Friend friend = friends.First();

			RefreshFriendsList();
			cboWindow.SelectedItem = $"{friend.Name} - {friend.Id}";
		}

		private void btnFriendRefresh_Click(object sender, EventArgs e)
		{
			RefreshFriendsList();
		}
	}
}
