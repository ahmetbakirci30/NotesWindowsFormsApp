using System.Collections.Generic;
using System.IO;

namespace Notes
{

    public class User
    {

        public string Username { get; set; }

        public string Password { get; set; }

        public User(string username, string password)
        {

            Username = username;

            Password = password;

        }

        static readonly string path = "Users.txt";

        public static void Write(User user)
        {
            List<User> users = new List<User>
            {

                user

            };

            Write(users);

        }

        public static void Write(List<User> users)
        {

            if (!File.Exists(path))
            {

                StreamWriter sw = new StreamWriter(path, true);

                foreach (User user in users)

                    sw.WriteLine(string.Join(";", user.Username, user.Password));

                sw.Close();

            }

        }

        public static User Read(string username)
        {

            List<User> users = Read();

            foreach(User user in users)
            {

                if (username == user.Username)

                    return user;

            }

            return null;

        }

        public static List<User> Read()
        {

            List<User> Users = new List<User>();

            if (File.Exists(path))
            {

                StreamReader sr = new StreamReader(path);

                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();

                    string[] values = line.Split(';');

                    User user = new User(values[0], values[1]);

                    Users.Add(user);

                }

                sr.Close();

            }

            return Users;

        }

    }

}