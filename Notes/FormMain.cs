using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notes
{

    public partial class FormMain : Form
    {

        public FormMain()
        {

            InitializeComponent();

        }

        private void Username_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(username.Text))
            {

                username.ForeColor = Color.Silver;

                username.Text = "Enter Your Username...";

            }

        }

        private void Username_Enter(object sender, EventArgs e)
        {

            if (username.Text.Equals("Enter Your Username..."))
            {

                username.Text = string.Empty;

                username.ForeColor = Color.Black;

            }

        }

        private void Password_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(password.Text))
            {

                password.ForeColor = Color.Silver;

                password.Text = "Enter Your Password...";

            }

        }

        private void Password_Enter(object sender, EventArgs e)
        {

            if (password.Text.Equals("Enter Your Password..."))
            {

                password.Text = string.Empty;

                password.ForeColor = Color.Black;

            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            List<User> users = User.Read();

            foreach (User user in users)
            {

                if (user.Username.Equals(username.Text) && user.Password.Equals(password.Text))
                {

                    Hide();

                    FormMyNotes welcome = new FormMyNotes(user);

                    welcome.Show();

                    return;

                }

            }

            MessageBox.Show("The username or password you entered is incorrect!");

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            FormAddUser add = new FormAddUser();

            add.ShowDialog();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            username.Text = "Enter Your Username...";

            password.Text = "Enter Your Password...";

        }

    }

}