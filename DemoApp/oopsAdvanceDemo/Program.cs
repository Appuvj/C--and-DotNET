using oopsAdvanceDemo;

internal class Program
{
    private static void Main(string[] args)
    {

        BMW b=new BMW();
        b.brand = "BMW";
        b.model = "X-Series";
        b.comfort = "Massage Seats";

        Console.WriteLine(b.getcardetails());

        Fortuner f=new Fortuner();
        f.brand = "Toyoto Fortuner";
        f.model = "Fortuner Mass";
        f.power = "250km/hr";

        Console.WriteLine(f.getcardetails());



        //Person p = new Person("vijay","kumar","Male");
        //p.Display();

        //p.FirstName = "vijay";
        //p.LastName = "kumar";
        //p.Gender = "Male";

        //Console.WriteLine("name: "+p.FirstName+" "+p.LastName);
        //Console.WriteLine("gender: "+p.Gender);
        Console.WriteLine("\n");

        //Student student = new Student("ravi", "kumar", "Male",1,80);
        //student.Display();

        //student.FirstName = "karupu";
        //student.LastName = "mass";
        //student.Gender = "Male";
        //student.StudentId = 1;
        //student.Marks = 80;

        //Console.WriteLine("Name: "+student.FirstName+" "+student.LastName);
        //Console.WriteLine("Gender: " + student.Gender);
        //Console.WriteLine("StudentID: "+student.StudentId);
        //Console.WriteLine("Marks: "+student.Marks);
        Console.WriteLine("\n");

        //Employee employee = new Employee("sanjai", "kumar", "Male",2,100000);
        //employee.Display();

        //employee.FirstName = "Hamsa";
        //employee.LastName = "vanan";
        //employee.Gender = "Male";
        //employee.EmpId = 1;
        //employee.Salary = 80000;

        //Console.WriteLine("Name: " + employee.FirstName + " " + employee.LastName);
        //Console.WriteLine("Gender: " + employee.Gender);
        //Console.WriteLine("EmpID: " + employee.EmpId);
        //Console.WriteLine("Salary: " + employee.Salary);
        Console.WriteLine("\n");


    }
}