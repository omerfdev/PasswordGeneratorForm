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
            SuspendLayout();
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(100, 130);
            txtBoxPassword.MaxLength = 50;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PlaceholderText = "Your Password";
            txtBoxPassword.Size = new Size(550, 27);
            txtBoxPassword.TabIndex = 0;
            txtBoxPassword.TextChanged += textBox1_TextChanged;
            // 
            // lblPasswordShow
            // 
            lblPasswordShow.AutoSize = true;
            lblPasswordShow.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPasswordShow.Location = new Point(237, 198);
            lblPasswordShow.Name = "lblPasswordShow";
            lblPasswordShow.Size = new Size(13, 20);
            lblPasswordShow.TabIndex = 1;
            lblPasswordShow.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 353);
            Controls.Add(lblPasswordShow);
            Controls.Add(txtBoxPassword);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 400);
            MinimumSize = new Size(800, 400);
            Name = "Form1";
            Text = "RandomPasswordGenerator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxPassword;
        private Label lblPasswordShow;
    }
}