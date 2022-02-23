using System;
namespace csharp_learning
{
    public class lesson_20
    {
        public static void encapsulation()
        {
            User user = new User(username: "burakbilgin", password: "test");
            user.GetUser();
        }
    }
    class User
    {
        private string _name;
        private string _surname;
        private string _username;
        private string _password;

        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get => _surname; set => _surname = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        public User() { }
        public User(string username = null, string password = null)
        {
            if (username == null)
            {
                Console.WriteLine("Kullanıcı adınızı veya şifrenizi boş bırakamazsınız!");
            }
            else if (password == null)
            {
                Console.WriteLine("Kullanıcı adınızı veya şifrenizi boş bırakamazsınız!");
            }
            else
            {
                Username = username;
                Password = password;
            }
        }

        public void GetUser()
        {
            if (Username != null) Console.WriteLine($"Username: {Username}");
            if (Password != null) Console.WriteLine($"Password: {Password}");
        }
    }
}