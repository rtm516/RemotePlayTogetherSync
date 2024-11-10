using Steamworks;
using Steamworks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotePlayTogetherSync
{
    internal class Worker
	{
		private SteamAppList.App _App;
		private Friend _Friend;
		private System.Timers.Timer internalTimer;

		public Worker(SteamAppList.App app)
		{
			this._App = app;

			// Initialize the connection to Steam as the selected app
			SteamClient.Init((uint)_App.Id, true);
			Logs.Info($"Initialized as {_App.Name} ({_App.Id})");

			// Setup the timer for updates
			internalTimer = new();
			internalTimer.Interval = 10 * 1000; // 10s
			internalTimer.Elapsed += (sender, e) => Tick();
		}

		~Worker()
		{
			Stop();
		}

		/// <summary>
		/// Get the friends list from Steam
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Friend> GetFriends()
		{
			return SteamFriends.GetFriends();
		}

		/// <summary>
		/// Start monitoring the achievements of a friend
		/// </summary>
		/// <param name="friend"></param>
		public void Start(Friend friend)
		{
			this._Friend = friend;

			Logs.Info("Loading achievements...");
			Logs.Info($"Found {SteamUserStats.Achievements.Count()} achievements");

			Tick();

			internalTimer.Start();
		}

		/// <summary>
		/// Compare the achievements of the friend with your own and unlock them if necessary
		/// </summary>
		public void Tick()
		{
			Logs.Debug("Comparing friend stats...");
			this._Friend.RequestUserStatsAsync().ContinueWith((loaded) =>
			{
				// Ensure the stats are loaded
				if (!loaded.Result)
				{
					Logs.Error("Unable to load friend stats");
					return;
				}

				bool changed = false;
				foreach (Achievement achievement in SteamUserStats.Achievements)
				{
					// Get the achievement details
					string achievementName = achievement.Identifier;
					bool isAchieved = achievement.State;
					bool isAchievedFriend = this._Friend.GetAchievement(achievement.Identifier);

					//Logs.Debug($"{achievementName}: {isAchieved} (you) vs {isAchievedFriend} (friend)");

					// Skip if the achievement its locked for the friend or unlocked for you
					if (!isAchievedFriend || isAchieved) continue;

					// Unlock the achievement
					Logs.Info($"Achievement {achievementName} is achieved by friend but not by you, unlocking...");
					achievement.Trigger(true);
					changed = true;
				}

				// Debug log if no changes were made
				if (!changed)
				{
					Logs.Debug("No changes to unlocked achievements");
				}
			});
		}

		/// <summary>
		/// Stop monitoring the achievements of a friend
		/// </summary>
		public void Stop()
		{
			internalTimer.Stop();
			SteamClient.Shutdown();
		}
	}
}
