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
        private string address;
        private bool isMarried;

        public User(string username,string password) 
        {
            this.username = username;
            this.password = password;
        } public User(string username,string password,string message) 
        {
            this.username = username;
            this.password = password;
            this.message = message;
        } public User(string username,string password,string message,string address) 
        {
            this.username = username;
            this.password = password;
            this.message = message;
        } public User(string username,string password,string message, string address,bool isMarried) 
        {
            this.username = username;
            this.password = password;
            this.message = message;
            this.address = address;
            this.isMarried = isMarried;
        }

        public void getDetails()
        {
            Console.WriteLine("username : " + username);
            Console.WriteLine("password : " + password);

            if (this.address != null)
            {
                Console.WriteLine("address : " + this.address);

            }
            Console.WriteLine("is married : " + this.isMarried);
        }




        public string CheckLogin()
        {
            if (this.username == "Admin" && this.password == "manager")
            {
                if (this.message == null)
                {
                    this.message = "you are logged in as admin";
                }
            }
            else if (this.username.StartsWith("User") && this.password == "Pass")
            {

                if (this.message == null)
                {
                    this.message = "you are logged in as user";
                }

            }
            else
            {

                if (this.message == null)
                {
                    this.message = "invalid login";
                }
            }
            return this.message;

        }
    }
}
