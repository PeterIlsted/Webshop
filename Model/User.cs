using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserID { get; set; }
        public User(string usernname, string password, int userID)
        {
            Username = usernname;
            Password = password;
            UserID = userID;
        }
        public User(string usernname, string password) : this(usernname, password, 0) { }
        public User(int userID) : this(null, null, userID) { }
    }
}
