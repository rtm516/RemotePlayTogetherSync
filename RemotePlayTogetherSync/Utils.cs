using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotePlayTogetherSync
{
	internal class Utils
	{
		public static string GetSteamInstallPath()
		{
			string registryKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam"; // For 64-bit systems
			string installPath = (string)Registry.GetValue(registryKey, "InstallPath", null);

			if (installPath == null)
			{
				// Try the 32-bit registry key for 32-bit systems or in case Steam was installed in Program Files (x86)
				registryKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam";
				installPath = (string)Registry.GetValue(registryKey, "InstallPath", null);
			}

			return installPath;
		}

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

		public static string Format(int number)
		{
			return $"{number:n}";
		}
	}
}
