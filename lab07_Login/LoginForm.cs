using System;
using System.Windows.Forms;

namespace Login
{
    // ЛР7 ІЗВП: форма входу з перевіркою заповнення полів
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Заповніть усі поля");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
