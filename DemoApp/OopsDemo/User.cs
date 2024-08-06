using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class User
    {
        private string username;
        private string password;
        private string message;

        public User(string username,string password,string message="") 
        {
            this.username = username;
            this.password = password;
           

        }

        public string CheckLogin()
        {
            if (this.username == "Admin" && this.password == "manager")
            {
                this.message = "you are logged in as admin";
            }
            else if (this.username.StartsWith("User") && this.password == "Pass")
            {
                this.message = "you are logged in as User";

            }
            else
            {
                this.message = "invalid login";
            }
            return this.message;

        }
    }
}
