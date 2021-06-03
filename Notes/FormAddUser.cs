using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notes
{

    public partial class FormAddUser : Form
    {

        public FormAddUser()
        {

            InitializeComponent();

        }

        private void Username_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(username.Text))
            {

                username.ForeColor = Color.Silver;

                username.Text = "Username...";

            }

        }

        private void Password_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(password.Text))
            {

                password.ForeColor = Color.Silver;

                password.Text = "Password...";

            }

        }

        private void Username_Enter(object sender, EventArgs e)
        {

            if (username.Text.Equals("Username..."))
            {

                username.Text = string.Empty;

                username.ForeColor = Color.Black;

            }

        }

        private void Password_Enter(object sender, EventArgs e)
        {

            if (password.Text.Equals("Password..."))
            {

                password.Text = string.Empty;

                password.ForeColor = Color.Black;

            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text)

            || username.Text.Equals("Username...") || password.Text.Equals("Password..."))

                MessageBox.Show("Enter a Username and a Password!");

            else
            {

                string kullaniciAdi = username.Text;

                string sifre = password.Text;

                User us = new User(kullaniciAdi, sifre);

                User.Write(us);

                MessageBox.Show("You can login!");

                Close();

            }

        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {

            username.Text = "Username...";

            password.Text = "Password...";

        }
    }
}