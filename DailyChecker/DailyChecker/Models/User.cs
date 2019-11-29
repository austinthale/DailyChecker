using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyChecker.Models
{
    public class User
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public bool ValidateLogin()
        {
            return (!String.IsNullOrEmpty(this.Username) && !String.IsNullOrEmpty(this.Password));
        }
    }
}
