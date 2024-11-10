using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RemotePlayTogetherSync
{
	internal class SteamAppList
	{
		public class AppList
		{
			[JsonPropertyName("apps")]
			public required List<App> Apps { get; set; }
		}

		public class App
		{
			[JsonPropertyName("appid")]
			public int Id { get; set; }
			[JsonPropertyName("name")]
			public required string Name { get; set; }
		}

		[JsonPropertyName("applist")]
		public required AppList List { get; set; }
	}
}