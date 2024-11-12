namespace RemotePlayTogetherSync
{
	partial class FrmInputBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblMessage = new Label();
			txtInput = new TextBox();
			btnOk = new Button();
			btnCancel = new Button();
			SuspendLayout();
			// 
			// lblMessage
			// 
			lblMessage.AutoSize = true;
			lblMessage.Location = new Point(12, 9);
			lblMessage.Name = "lblMessage";
			lblMessage.Size = new Size(53, 15);
			lblMessage.TabIndex = 0;
			lblMessage.Text = "Message";
			// 
			// txtInput
			// 
			txtInput.Location = new Point(12, 27);
			txtInput.Name = "txtInput";
			txtInput.Size = new Size(272, 23);
			txtInput.TabIndex = 1;
			// 
			// btnOk
			// 
			btnOk.Location = new Point(128, 56);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(75, 23);
			btnOk.TabIndex = 2;
			btnOk.Text = "&Ok";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(209, 56);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "&Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// FrmInputBox
			// 
			AcceptButton = btnOk;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(296, 91);
			Controls.Add(btnCancel);
			Controls.Add(btnOk);
			Controls.Add(txtInput);
			Controls.Add(lblMessage);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FrmInputBox";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Title";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblMessage;
		private TextBox txtInput;
		private Button btnOk;
		private Button btnCancel;
	}
}