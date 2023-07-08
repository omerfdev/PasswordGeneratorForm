namespace PasswordGeneratorForm
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			txtBoxPassword = new TextBox();
			lblPasswordShow = new Label();
			txtBoxConfirmPassword = new TextBox();
			btnLogin = new Button();
			SuspendLayout();
			// 
			// txtBoxPassword
			// 
			txtBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
			txtBoxPassword.Location = new Point(142, 94);
			txtBoxPassword.MaxLength = 50;
			txtBoxPassword.Name = "txtBoxPassword";
			txtBoxPassword.PlaceholderText = "Your Password";
			txtBoxPassword.Size = new Size(478, 27);
			txtBoxPassword.TabIndex = 0;
			
			// 
			// lblPasswordShow
			// 
			lblPasswordShow.AutoSize = true;
			lblPasswordShow.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			lblPasswordShow.Location = new Point(295, 245);
			lblPasswordShow.Name = "lblPasswordShow";
			lblPasswordShow.Size = new Size(13, 20);
			lblPasswordShow.TabIndex = 1;
			lblPasswordShow.Text = " ";
			// 
			// txtBoxConfirmPassword
			// 
			txtBoxConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
			txtBoxConfirmPassword.Location = new Point(142, 139);
			txtBoxConfirmPassword.MaxLength = 50;
			txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
			txtBoxConfirmPassword.PlaceholderText = "Confirm Password";
			txtBoxConfirmPassword.Size = new Size(478, 27);
			txtBoxConfirmPassword.TabIndex = 2;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(295, 194);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(99, 34);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(782, 353);
			Controls.Add(btnLogin);
			Controls.Add(txtBoxConfirmPassword);
			Controls.Add(lblPasswordShow);
			Controls.Add(txtBoxPassword);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(800, 400);
			MinimumSize = new Size(800, 400);
			Name = "Form1";
			Text = "RandomPasswordGenerator";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtBoxPassword;
		private Label lblPasswordShow;
		private TextBox txtBoxConfirmPassword;
		private Button btnLogin;
	}
}