﻿using Steamworks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static RemotePlayTogetherSync.SteamAppList;

namespace RemotePlayTogetherSync
{
	public partial class FrmMain : Form
	{
		private List<App> _appList = new();
		private Worker? _syncWorker;

		public FrmMain()
		{
			InitializeComponent();
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			// Check if Steam is installed
			if (string.IsNullOrEmpty(Utils.GetSteamInstallPath()) == true)
			{
				MessageBox.Show("Failed to get Steam install path");
				Application.Exit();
				return;
			}

			// Set the logs textbox
			Logs.SetTextBox(txtLogs);

			// Load Steam apps in the background
			Logs.Info($"Loading Steam apps...");
			Task.Run(async () =>
			{
				try
				{
					using (HttpClient httpClient = new())
					{
						string json = await httpClient.GetStringAsync("https://api.steampowered.com/ISteamApps/GetAppList/v2/");
						List<App>? fetchedList = JsonSerializer.Deserialize<SteamAppList>(json)?.List?.Apps;

						if (fetchedList == null)
						{
							throw new Exception("No apps returned from API");
						}

						// Remove 753 from the list, as thats the Steam app itself
						fetchedList.RemoveAll(app => app.Id == 753);

						_appList.Clear();
						_appList.AddRange(fetchedList);
					}
				}
				catch (Exception e)
				{
					Logs.Error($"Failed to load Steam apps: {e.Message}");
					Logs.Error($"Please restart the application");
					return;
				}

				// Enable the window selection UI
				Invoke(() =>
				{
					btnWindow.Enabled = true;
					btnWindowAuto.Enabled = true;
					btnWindowRefresh.Enabled = true;
					btnWindowManual.Enabled = true;
					cboWindow.Enabled = true;
				});

				Logs.Info($"Loaded {Utils.Format(_appList.Count)} apps");
			});

			RefreshWindowList();
		}

		#region Window UI
		private void btnWindow_Click(object sender, EventArgs e)
		{
			// Find the selected app object
			App? foundApp = _appList.FirstOrDefault(app => app.Name.Equals(cboWindow.SelectedItem));
			if (foundApp == null)
			{
				MessageBox.Show($"No Steam game matching the name '{cboWindow.SelectedItem}'");
				return;
			}

			SetApp(foundApp);
		}

		private void btnWindowManual_Click(object sender, EventArgs e)
		{
			string? value = FrmInputBox.Show("Manual App ID input", "Enter the Steam App ID of the game");

			if (string.IsNullOrEmpty(value)) return;

			try
			{
				// Find the selected app object
				int intValue = int.Parse(value);
				App? foundApp = _appList.FirstOrDefault(app => app.Id.Equals(intValue));
				if (foundApp == null)
				{
					MessageBox.Show($"No Steam game matching the name '{value}'");
					return;
				}

				// Refresh the window list and select the found app
				cboWindow.Text = foundApp.Name;
				SetApp(foundApp);
			}
			catch (Exception)
			{
				MessageBox.Show("Invalid app id");
			}
		}

		private void btnWindowRefresh_Click(object sender, EventArgs e)
		{
			RefreshWindowList();
		}

		private void btnWindowAuto_Click(object sender, EventArgs e)
		{
			// Check all windows for a known Steam game title
			List<string> titles = Utils.GetWindowTitles();
			App? foundApp = null;
			foreach (string title in titles)
			{
				foundApp = _appList.FirstOrDefault(app => title.Equals(app.Name));
				if (foundApp != null)
				{
					break;
				}
			}

			if (foundApp == null)
			{
				MessageBox.Show("No window found matching a known Steam game");
				return;
			}

			// Refresh the window list and select the found app
			RefreshWindowList();
			cboWindow.SelectedItem = foundApp.Name;
		}

		private void RefreshWindowList()
		{
			// Re-populate the list
			cboWindow.Items.Clear();
			string[] windows = Utils.GetWindowTitles()
				.Order()
				.ToArray();
			cboWindow.Items.AddRange(windows);

			// Fix the selected item
			Utils.FixSelectedItem(cboWindow);
		}

		private void SetApp(App targetApp)
		{
			_syncWorker = new(targetApp);

			RefreshFriendsList();

			// Disable the window selection UI
			btnWindow.Enabled = false;
			btnWindowAuto.Enabled = false;
			btnWindowRefresh.Enabled = false;
			btnWindowManual.Enabled = false;
			cboWindow.Enabled = false;

			// Enable the friend selection UI
			btnFriend.Enabled = true;
			btnFriendAuto.Enabled = true;
			btnFriendRefresh.Enabled = true;
			cboFriend.Enabled = true;

			// Enable the stop button
			btnStop.Enabled = true;
		}
		#endregion

		#region Friend UI
		private void btnFriend_Click(object sender, EventArgs e)
		{
			if (_syncWorker == null) return;

			// Find the selected friend object
			IEnumerable<Friend> friends = _syncWorker.GetFriends().Where(friend => $"{friend.Name} - {friend.Id}".Equals(cboFriend.SelectedItem));
			if (friends.Count() != 1)
			{
				MessageBox.Show("No friend found matching that name");
				return;
			}

			// Disable the friend selection UI
			btnFriend.Enabled = false;
			btnFriendAuto.Enabled = false;
			btnFriendRefresh.Enabled = false;
			cboFriend.Enabled = false;

			// Start the sync worker
			_syncWorker.Start(friends.First());
		}

		private void btnFriendRefresh_Click(object sender, EventArgs e)
		{
			RefreshFriendsList();
		}

		private void btnFriendAuto_Click(object sender, EventArgs e)
		{
			if (_syncWorker == null) return;

			// Find the friend playing the selected game
			IEnumerable<Friend> friends = _syncWorker.GetFriends().Where(friend => friend.IsPlayingThisGame);
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

			// Refresh the friends list and select the found friend
			RefreshFriendsList();
			cboWindow.SelectedItem = $"{friend.Name} - {friend.Id}";
		}

		private void RefreshFriendsList()
		{
			if (_syncWorker == null) return;

			// Re-populate the list
			cboFriend.Items.Clear();
			string[] friends = _syncWorker.GetFriends()
				.Select(friend => $"{friend.Name} - {friend.Id}")
				.Order()
				.ToArray();
			cboFriend.Items.AddRange(friends);

			// Fix the selected item
			Utils.FixSelectedItem(cboFriend);
		}
		#endregion

		#region Toolstrip
		private void toolBtnHelp_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://github.com/rtm516/RemotePlayTogetherSync/",
				UseShellExecute = true
			});
		}

		private void toolBtnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void toolBtnSettings_Click(object sender, EventArgs e)
		{
			FrmSettings frmSettings = new();
			frmSettings.ShowDialog();
		}
		#endregion

		private void btnStop_Click(object sender, EventArgs e)
		{
			// Stop the sync worker
			if (_syncWorker != null)
			{
				_syncWorker.Stop();
				_syncWorker = null;
			}

			// Reset the combo boxes
			cboWindow.SelectedIndex = -1;
			cboFriend.SelectedIndex = -1;
			RefreshWindowList();

			// Enable the window selection UI
			btnWindow.Enabled = true;
			btnWindowAuto.Enabled = true;
			btnWindowRefresh.Enabled = true;
			btnWindowManual.Enabled = true;
			cboWindow.Enabled = true;

			// Disable the friend selection UI
			btnFriend.Enabled = false;
			btnFriendAuto.Enabled = false;
			btnFriendRefresh.Enabled = false;
			cboFriend.Enabled = false;

			// Disable the stop button
			btnStop.Enabled = false;

			Logs.Info("Stopped and reset");
		}
	}
}
