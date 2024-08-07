using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Student
    {

        public int studentId;
        public string studentname;
        public int marks;
        private int age;

        public static string collegename;

        //public void SetAge(int value) 
        //{
        //    age=value;
        //}
        //public int GetAge()
        //{
        //    return age;   
        //}

                              //getter,setter method
        public int Age
        {
            get { return age; }
            set
            {
                if (value >=18 && value <= 60)
                {
                    age = value;
                }
            }
        }

    }
}
