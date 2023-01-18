using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    public class Users
    {
        private string username;
        private string password;
        private string type;

        public Users(string username, string password, string type)
        {
            UserName = username;
            Password = password;
            Type = type;
        }

        public String UserName
        {
            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
