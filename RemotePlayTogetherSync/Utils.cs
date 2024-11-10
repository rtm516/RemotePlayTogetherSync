using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotePlayTogetherSync
{
	internal class Utils
	{
		/// <summary>
		/// Get the install path of Steam
		/// </summary>
		/// <returns></returns>
		public static string? GetSteamInstallPath()
		{
			string registryKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam"; // For 64-bit systems
			string? installPath = (string?)Registry.GetValue(registryKey, "InstallPath", null);

			if (installPath == null)
			{
				// Try the 32-bit registry key for 32-bit systems or in case Steam was installed in Program Files (x86)
				registryKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam";
				installPath = (string?)Registry.GetValue(registryKey, "InstallPath", null);
			}

			return installPath;
		}

		/// <summary>
		/// Get the titles of all open windows
		/// </summary>
		/// <returns></returns>
		public static List<string> GetWindowTitles()
		{
			List<string> titles = new();
			Process[] processlist = Process.GetProcesses();
			foreach (Process process in processlist)
			{
				if (string.IsNullOrEmpty(process.MainWindowTitle)) continue;
				titles.Add(process.MainWindowTitle);
			}
			return titles;
		}

		/// <summary>
		/// Fix the selected item in a combobox
		/// </summary>
		/// <param name="comboBox"></param>
		public static void FixSelectedItem(ComboBox comboBox)
		{
			// Clear the selected item if its nolonger valid
			if (comboBox.SelectedItem != null && !comboBox.Items.Contains(comboBox.SelectedItem))
			{
				comboBox.SelectedItem = null;
			}

			// Default to the first item
			if (comboBox.SelectedItem == null)
			{
				comboBox.SelectedItem = comboBox.Items[0];
			}
		}

		/// <summary>
		/// Format a number with commas
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static string Format(int number)
		{
			return $"{number:n}";
		}
	}
}
