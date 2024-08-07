using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsAdvanceDemo
{
    class Student : Person

    {
        public int StudentId { get; set; }
        public int Marks { get; set; }

        public Student(string FirstName, string LastName, string Gender,int studentId, int marks):base(FirstName, LastName, Gender)
        {
            this.StudentId = studentId;
            this.Marks = marks;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Student Id: "+this.StudentId);
            Console.WriteLine("Marks: "+this.Marks);
        }
    }
}
