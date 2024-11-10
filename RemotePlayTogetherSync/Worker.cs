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

			SteamClient.Init((uint)_App.Id, true);

			Logs.Info($"Initialized as {_App.Name} ({_App.Id})");

			internalTimer = new();
			internalTimer.Interval = 10 * 1000; // 10s
			internalTimer.Elapsed += (sender, e) => Tick();
		}

		~Worker()
		{
			Stop();
		}

		public IEnumerable<Friend> GetFriends()
		{
			return SteamFriends.GetFriends();
		}

		public void Start(Friend friend)
		{
			this._Friend = friend;

			Logs.Info("Loading achievements...");
			Logs.Info($"Found {SteamUserStats.Achievements.Count()} achievements");

			Tick();

			internalTimer.Start();
		}

		public void Tick()
		{
			Logs.Debug("Comparing friend stats...");
			this._Friend.RequestUserStatsAsync().ContinueWith((loaded) =>
			{
				if (!loaded.Result)
				{
					Logs.Error("Unable to load friend stats");
					return;
				}

				bool changed = false;
				foreach (Achievement achievement in SteamUserStats.Achievements)
				{
					string achievementName = achievement.Identifier;
					bool isAchieved = achievement.State;
					bool isAchievedFriend = this._Friend.GetAchievement(achievement.Identifier);

					//Logs.Debug($"{achievementName}: {isAchieved} (you) vs {isAchievedFriend} (friend)");

					if (isAchievedFriend && !isAchieved)
					{
						Logs.Info($"Achievement {achievementName} is achieved by friend but not by you, unlocking...");
						achievement.Trigger(true);
						changed = true;
					}
				}

				if (!changed)
				{
					Logs.Debug("No changes to unlocked achievements");
				}
			});
		}

		public void Stop()
		{
			internalTimer.Stop();
			SteamClient.Shutdown();
		}
	}
}
