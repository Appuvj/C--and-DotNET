using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsAdvanceDemo
{
    class Person
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }


        public Person(string FirstName,string LastName,string Gender) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;

        }

        public void Display()
        {
            Console.WriteLine("Name: "+this.FirstName+" "+this.LastName);
            Console.WriteLine("Gender: " + this.Gender);
        }



    }
}
