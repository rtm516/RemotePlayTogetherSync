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
	public partial class FrmInputBox : Form
	{
		public FrmInputBox()
		{
			InitializeComponent();
		}

		public static string? Show(string title, string prompt)
		{
			using (FrmInputBox frm = new())
			{
				frm.Text = title;
				frm.lblMessage.Text = prompt;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					return frm.txtInput.Text;
				}
				else
				{
					return null;
				}
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
