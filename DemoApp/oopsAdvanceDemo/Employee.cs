using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsAdvanceDemo
{
    class Employee :Person
    {
        public int EmpId { get; set; }
        public double Salary { get; set; }

        public Employee(string FirstName, string LastName, string Gender,int EmpId, double Salary):base(FirstName, LastName, Gender)
        {
            this.EmpId = EmpId;
            this.Salary = Salary;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Employee Id: "+this.EmpId);
            Console.WriteLine("Salary: "+this.Salary);
        }

    }
}
