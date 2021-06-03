using System;
using System.Collections.Generic;
using System.IO;

namespace Notes
{

    class Note
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public User User { get; set; }

        public Note(int id, string content, User user)
        {

            Id = id;

            Content = content;

            User = user;

        }

        static readonly string filePath = "Notes.txt";

        public static void Write(Note note)
        {

            List<Note> notes = new List<Note>
            {

                note

            };

            Write(notes);

        }

        public static void Write(List<Note> notes)
        {

            StreamWriter sw = new StreamWriter(filePath, true);

            foreach (Note Note in notes)

                sw.WriteLine(string.Join(";", Note.Id, Note.Content, Note.User.Username));

            sw.Close();

        }

        public static Note Read(int id)
        {

            Note note = null;

            if (File.Exists(filePath))
            {

                StreamReader sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();

                    string[] values = line.Split(';');

                    if (id == Convert.ToInt32(values[0]))

                        note = new Note(id, values[1], User.Read(values[2]));

                }

                sr.Close();

            }

            return note;

        }

        public static List<Note> ReadAll()
        {

            List<Note> notes = new List<Note>();

            if (File.Exists(filePath))
            {

                StreamReader sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();

                    string[] values = line.Split(';');

                    Note note = new Note(Convert.ToInt32(values[0]), values[1], User.Read(values[2]));

                    notes.Add(note);

                }

                sr.Close();

            }

            return notes;

        }

        public static List<Note> ReadUserNotes(User user)
        {

            StreamReader sr = new StreamReader(filePath);

            List<Note> notes = new List<Note>();

            while (!sr.EndOfStream)
            {

                string line = sr.ReadLine();

                string[] values = line.Split(';');

                if (user.Username == values[2])

                    notes.Add(new Note(Convert.ToInt32(values[0]), values[1], user));

            }

            sr.Close();

            return notes;

        }

        public static void Remove(int id)
        {

            List<string> lines = new List<string>();

            StreamReader sr = new StreamReader(filePath);

            while (!sr.EndOfStream)
            {

                string line = sr.ReadLine();

                string[] values = line.Split(';');

                if (Convert.ToInt32(values[0]) != id)

                    lines.Add(line);

            }

            sr.Close();

            File.WriteAllLines(filePath, lines);

        }

        public static int Counter()
        {

            StreamReader sr = new StreamReader(filePath);

            int counter = 0;

            while (!sr.EndOfStream)
            {

                string line = sr.ReadLine();

                string[] values = line.Split(';');

                counter = Convert.ToInt32(values[0]);

            }

            sr.Close();

            return ++counter;

        }

    }

}