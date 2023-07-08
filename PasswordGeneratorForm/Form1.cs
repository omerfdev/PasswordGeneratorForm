using System.Runtime.CompilerServices;

namespace PasswordGeneratorForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}
		public delegate void PasswordMethodDelegate(TextBox txtBoxPassword, TextBox textBoxConfirmPassword, Label lblPasswordShow);
		public static PasswordMethodDelegate passwordMethodDelegate = PasswordMethod;


		public static void PasswordMethod(TextBox txtBoxPassword, TextBox txtBoxConfirmPassword, Label lblPasswordShow)
		{
			string password = txtBoxPassword.Text;
			string confirmPassword = txtBoxConfirmPassword.Text;

			if (password.Length > 16)
			{
				MessageBox.Show("The password can be up to 16 characters.");
			}
			else if (!password.Any(char.IsUpper) || !password.Any(char.IsLower))
			{
				MessageBox.Show("Password must contain at least one capital or small letter.");
			}
			else if (!password.Any(char.IsDigit))
			{
				MessageBox.Show("The password must contain at least one number.");
			}
			else if (!password.Any(c => "_,.,!,-,*,,".Contains(c)))
			{
				MessageBox.Show("Password is at least one _ . , ! must contain the character.");
			}
			else if (password != confirmPassword)
			{
				MessageBox.Show("Passwords do not match.");
			}
			else
			{
				MessageBox.Show($"Your Password {password}");
				if (txtBoxPassword.Text.Length <= 6) { lblPasswordShow.Text = "Password Level is Low"; lblPasswordShow.ForeColor = Color.Red; }
				else if (txtBoxPassword.Text.All(char.IsDigit) && txtBoxPassword.Text.All(char.IsLetter)) { lblPasswordShow.Text = "Password Level is Low"; lblPasswordShow.ForeColor = Color.Red; }
				else if (txtBoxPassword.Text.Length == 7 && txtBoxPassword.Text.Any(char.IsDigit) && txtBoxPassword.Text.Any(char.IsLetter)) { lblPasswordShow.Text = "Password Level is Good"; lblPasswordShow.ForeColor = Color.Orange; }
				else if (txtBoxPassword.Text.Length >= 8 && txtBoxPassword.Text.Any(char.IsLetter) && txtBoxPassword.Text.Any(char.IsDigit)) { lblPasswordShow.Text = "Password Level is Very Good"; lblPasswordShow.ForeColor = Color.Green; }
			}
		}
		private string dosyaYolu = "veriler.txt";
		private void btnLogin_Click(object sender, EventArgs e)
		{
			passwordMethodDelegate(txtBoxPassword, txtBoxConfirmPassword, lblPasswordShow);
			if (chkBoxRemindMe.Checked)
			{
				string[] veriler = { txtBoxPassword.Text, txtBoxConfirmPassword.Text };
				File.WriteAllLines(dosyaYolu, veriler);
			}
			else 
			{
				txtBoxPassword.Text = string.Empty; txtBoxConfirmPassword.Text = string.Empty;
				string[] veriler = { txtBoxPassword.Text, txtBoxConfirmPassword.Text };
				File.WriteAllLines(dosyaYolu, veriler);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (File.Exists(dosyaYolu))
			{
				string[] veriler = File.ReadAllLines(dosyaYolu);

				if (veriler.Length >= 2)
				{
					txtBoxPassword .Text = veriler[0];
					txtBoxConfirmPassword .Text = veriler[1];
				}
				else { txtBoxPassword.Text=string.Empty;txtBoxConfirmPassword.Text=string.Empty; }	
			}
		}
	}
}