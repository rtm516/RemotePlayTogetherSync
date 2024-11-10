using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotePlayTogetherSync
{
	internal class Logs
	{
		private static TextBox? textBox;

		public static void SetTextBox(TextBox textBox)
		{
			Logs.textBox = textBox;
		}

		private static void WriteLine(string text)
		{
			if (textBox == null) return;

			if (textBox.InvokeRequired)
			{
				textBox.Invoke(new Action(() => WriteLine(text)));
				return;
			}

			textBox.AppendText(text + Environment.NewLine);
		}

		private static void Log(string level, string text)
		{
			WriteLine($"[{DateTimeOffset.Now.ToString("HH:mm:ss")} {level.PadLeft(5)}] {text}");
		}

		public static void Error(string text)
		{
			Log("ERROR", text);
		}

		public static void Info(string text)
		{
			Log("INFO", text);
		}

		public static void Debug(string text)
		{
			Log("DEBUG", text);
		}
	}
}
