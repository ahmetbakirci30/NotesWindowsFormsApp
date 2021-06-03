using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notes
{

    public partial class UserInformations : Form
    {

        public UserInformations()
        {

            InitializeComponent();

        }

        private void UserInformations_Load(object sender, EventArgs e)
        {

            List<User> users = User.Read();

            foreach (User user in users)

                listViewUser.Items.Add(user.Username);

        }

    }

}