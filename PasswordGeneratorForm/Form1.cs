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
            if (textBox1.Text.Length <= 6) { label1.Text = "Parola Seviyesi Düşük"; label1.ForeColor = Color.Red; }
            else if (textBox1.Text.All(char.IsDigit) && textBox1.Text.All(char.IsLetter)) { label1.Text = "Parola Seviyesi Düşük"; label1.ForeColor = Color.Red; }
            else if (textBox1.Text.Length == 7 && textBox1.Text.Any(char.IsDigit) && textBox1.Text.Any(char.IsLetter)) { label1.Text = "Parola Seviyesi Orta"; label1.ForeColor = Color.Orange; }
        }
    }
}