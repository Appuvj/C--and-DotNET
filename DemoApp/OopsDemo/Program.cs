using System.Security.Cryptography;

namespace OopsDemo;


//class Age
//{
//    public readonly int _year;

//    public Age(int year)
//    {
//        this._year = year;
//        Console.WriteLine(this._year);
//    }
//}



 class Program
{
    private static void Main(string[] args)
    {

        User u1;

        for (int i = 0; i < 3; i++)
        {
            Console.Write("enter username : ");
            string username=Console.ReadLine();
            Console.Write("Enter password : ");
            string password=Console.ReadLine();
            u1=new User(username,password);
            string result = u1.CheckLogin();
            Console.WriteLine(result);
        }


       // Age a=new Age(2010);


        //Student s1, s2;

        //s1= new Student();
        //s2= new Student();

        //Student.collegename = "Anna university";

        //s1.studentId = 1;
        //s1.studentname = "vijay";
        //s1.marks = 85;

        //s2.studentId = 2;
        //s2.studentname = "karuppiah";
        //s2.marks = 80;

        //Console.WriteLine("college name : "+Student.collegename);
        //Console.WriteLine();
        //Console.WriteLine("student id : "+s1.studentId);
        //Console.WriteLine("student name : "+s1.studentname);
        //Console.WriteLine("student marks : "+s1.marks);
        //Console.WriteLine();
        //Console.WriteLine("student id : " + s2.studentId);
        //Console.WriteLine("student name : " + s2.studentname);
        //Console.WriteLine("student marks : " + s2.marks);


        //Employee e1, e2;

        //e1 = new Employee();
        //e2 = new Employee();

        //Employee.companyName = "ChangePond Technologies";

        //e1.employeeName = "vijay";
        //e1.employeeAge = 23;
        //e1.employeeSalary = 25000;

        //e2.employeeName = "karuppiah";
        //e2.employeeAge = 24;
        //e2.employeeSalary = 24000;

        //Console.WriteLine("Company name : "+Employee.companyName);
        //Console.WriteLine();
        //Console.WriteLine("Employee name : " + e1.employeeName);
        //Console.WriteLine("Employee age : " + e1.employeeAge);
        //Console.WriteLine("Employee salary : "+e1.employeeSalary);
        //Console.WriteLine();
        //Console.WriteLine("Employee name : " + e2.employeeName);
        //Console.WriteLine("Employee age : " + e2.employeeAge);
        //Console.WriteLine("Employee salary : " + e2.employeeSalary);





    }
}