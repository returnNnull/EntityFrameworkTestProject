using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTestProject.models
{
    internal class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string login, string password)
        {
          
            
            Login = login;
            Password = password;
        }

        public static List<User> CreateUsers() 
        {
            var users = new List<User>();
            users.Add(new User("admin", "admin"));
            users.Add(new User("user", "user"));

            return users;
        }

        public override string ToString()
        {
            return "login: " + Login + ", pass: " + Password;
        }

    }
}
