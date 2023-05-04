namespace PasswordGeneratorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text.Length <= 6) { lblPasswordShow.Text = "Parola Seviyesi Düşük"; lblPasswordShow.ForeColor = Color.Red; }
            else if (txtBoxPassword.Text.All(char.IsDigit) && txtBoxPassword.Text.All(char.IsLetter)) { lblPasswordShow.Text = "Parola Seviyesi Düşük"; lblPasswordShow.ForeColor = Color.Red; }
            else if (txtBoxPassword.Text.Length == 7 && txtBoxPassword.Text.Any(char.IsDigit) && txtBoxPassword.Text.Any(char.IsLetter)) { lblPasswordShow.Text = "Parola Seviyesi Orta"; lblPasswordShow.ForeColor = Color.Orange; }
            else if (txtBoxPassword.Text.Length >= 8 && txtBoxPassword.Text.Any(char.IsLetter) && txtBoxPassword.Text.Any(char.IsDigit)) { lblPasswordShow.Text = "Parola Seviyesi Yüksek"; lblPasswordShow.ForeColor = Color.Green; }
        }
    }
}