using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notes
{

    public partial class FormMyNotes : Form
    {

        readonly User user;

        public FormMyNotes(User user)
        {

            InitializeComponent();

            this.user = user;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Notes.Text))
            {

                Note note = new Note(Note.Counter(), Notes.Text.ToString(), user);

                Note.Write(note);

                listBoxNotes.Items.Add(note);

                Notes.Clear();

            }

        }

        private void FormMyNotes_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        private void FormMyNotes_Load(object sender, EventArgs e)
        {

            List<Note> notes = Note.ReadUserNotes(user);

            listBoxNotes.DisplayMember = "Content";

            foreach (Note note in notes)

                listBoxNotes.Items.Add(note);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

            if (listBoxNotes.SelectedIndex == -1)

                return;

            Note note = (Note)listBoxNotes.SelectedItem;

            Note.Remove(note.Id);

            listBoxNotes.Items.RemoveAt(listBoxNotes.SelectedIndex);

        }

        private void BtnShowAllUsers_Click(object sender, EventArgs e)
        {

            UserInformations user = new UserInformations();

            user.Show();

        }

    }

}