using System.Runtime.CompilerServices;

namespace PasswordGeneratorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public delegate void PasswordMethodDelegate(TextBox txtBoxPassword, Label lblPasswordShow);
        public static PasswordMethodDelegate passwordMethodDelegate = PasswordMethod;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            passwordMethodDelegate(txtBoxPassword, lblPasswordShow);
        }

        public  static void PasswordMethod(TextBox txtBoxPassword,Label lblPasswordShow) 
        {
            if (txtBoxPassword.Text.Length <= 6) { lblPasswordShow.Text = "Password Level is Low"; lblPasswordShow.ForeColor = Color.Red; }
            else if (txtBoxPassword.Text.All(char.IsDigit) && txtBoxPassword.Text.All(char.IsLetter)) { lblPasswordShow.Text = "Password Level is Low"; lblPasswordShow.ForeColor = Color.Red; }
            else if (txtBoxPassword.Text.Length == 7 && txtBoxPassword.Text.Any(char.IsDigit) && txtBoxPassword.Text.Any(char.IsLetter)) { lblPasswordShow.Text = "Password Level is Good"; lblPasswordShow.ForeColor = Color.Orange; }
            else if (txtBoxPassword.Text.Length >= 8 && txtBoxPassword.Text.Any(char.IsLetter) && txtBoxPassword.Text.Any(char.IsDigit)) { lblPasswordShow.Text = "Password Level is Very Good"; lblPasswordShow.ForeColor = Color.Green; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}