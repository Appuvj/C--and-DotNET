//ACCESS MODIFIERS IN .NET 
class Student
{
    private int std_id;
    protected int yob;
    internal int age;
    protected internal string gender;
    public string fname;

    public string getDetails()
    {
        std_id = 1;//Private members is accesible in the same class only.
        yob = 2001;//protected members is accessible in the same class and child class.
        age = 21;//Internal is accessible in same file but not other file .
        gender = "male";
        fname = "vijay";//public members is accessible in any class

        return "ID:" + std_id + "YOB :" + yob + " AGE :" + age + " GENDER:" + gender + "FIRST_NAME :" + fname;
    }
}

class School : Student
{
    public string schoolName;
    public string getDetailsWithSchool()
    {

        yob = 2001;//protected members is accessible in the same class and child class.
        age = 21;
        gender = "male";
        fname = "vijay";//public members is accessible in any class
        schoolName = "A.M.H.S.S";
        return "YOB :" + yob + " AGE :" + age + " GENDER:" + gender + "FIRST_NAME :" + fname + "SCHOOL_NAME :" + schoolName;
    }

}
class Parent
{
    public string getStudentDetails()
    {
        Student student = new Student();
        student.fname = "vijay";
        student.age = 21;
        student.gender = "Male";
        return "STUDENT_FNAME :" + student.fname + "STUDENT_AGE :" + student.age + "STUDENT_GENDER :" + student.gender;
    }
}

class Program
{
    private static void Main(string[] args)
    {


        Student student = new Student();
        string d1 = student.getDetails();
        Console.WriteLine(d1);
        School school = new School();
        string d2 = school.getDetailsWithSchool();
        Console.WriteLine(d2);
        Parent parent = new Parent();
        string d3 = parent.getStudentDetails();
        Console.WriteLine(d3);



        //Console.WriteLine("Hello, World!");
        //System.Console.ReadKey();
        //System.Console.Clear();
        //Console.WriteLine("welcome to dotnet class");
        //System.Console.ReadLine();

        //int num = 10;
        //Console.WriteLine(num);

        //sbyte a = 10;
        //byte b = 20;
        //short s = 30;
        //ushort f = 40;
        //uint g = 50;
        //long l = 60;
        //ulong r = 70;
        //float z = 10.23F;
        //double j = 100.234234;
        //decimal k = 110.2342324M;

        //uint min = uint.MinValue;
        //uint max = uint.MaxValue;

        //Console.WriteLine(min);
        //Console.WriteLine(max);

        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(s);
        //Console.WriteLine(f);
        //Console.WriteLine(g);
        //Console.WriteLine(l);
        //Console.WriteLine(r);
        //Console.WriteLine(z);
        //Console.WriteLine(j);
        //Console.WriteLine(k);


        //char ch = 'A';
        //Console.WriteLine(ch);

        //String str = "vijay@006";
        //Console.WriteLine(str);

        //bool value = true;
        //Console.WriteLine(value);


        // Operatores 

        //int num1, num2;
        //num1 = 10;
        //num2 = 20;

        //Console.WriteLine (num1+num2);
        //Console.WriteLine (num1-num2);
        //Console.WriteLine (num2*num1);
        //Console.WriteLine (num1/num2);
        //Console.WriteLine (num2%num1);

        //Console.WriteLine(num1 += num2);
        //Console.WriteLine(num1 -= num2);
        //Console.WriteLine(num2 *= num1);
        //Console.WriteLine(num1 /= num2);
        //Console.WriteLine(num2 %= num1);

        //int x=10,y=20,z=30;

        //bool result1=((x==y) && (y==z));
        //Console.WriteLine(result1);

        //bool result2=((x==z) || (y<z));
        //Console.WriteLine(result2);

        //bool result3 = !result1;
        //Console.WriteLine(result3);

        //string str1 = "good morning";
        //string str2 = "vijay";
        //Console.WriteLine (str1+" "+str2);

        //int num = 10;
        //Console.WriteLine (str1+num);

        //int num = 12;

        //string result = num % 2 == 0 ? "even" : "odd";
        //Console.WriteLine(result);      

        //if (num % 2 == 0)
        //{
        //    Console.WriteLine(num + " is even");
        //}
        //else
        //{
        //    Console.WriteLine(num + " is odd");
        //}

        //int year = 1900;

        //if (year % 400 == 0) 
        //{
        //    Console.WriteLine("leap year");

        //}
        //else if(year % 4 == 0 && year % 100 != 0 )
        //{
        //    Console.WriteLine("leap year");

        //}
        //else
        //{
        //    Console.WriteLine("not a leap year");
        //}

        //int marks = 26;

        //if(marks>=75)
        //{
        //    Console.WriteLine("destinction");
        //}

        //else if(marks>=60 && marks<75)
        //{
        //    Console.WriteLine("First class");

        //}
        //else if (marks>=40 && marks<60)
        //{
        //    Console.WriteLine("second class");
        //}
        //else
        //{
        //    Console.WriteLine("third class");
        //}

        //int a=50,b=210,c=30;

        //if (a > b && a > c)
        //{
        //    Console.WriteLine("a= " + a + " is greater");
        //}
        //else if (b > c)
        //{
        //    Console.WriteLine("b= " + b + " is greater");
        //}
        //else
        //{
        //    Console.WriteLine("c= "+c + " is greater");
        //}


        //string monthname = " ";
        //int monthno = 12;
        //switch (monthno)
        //{
        //    case 1: monthname = "january"; break;
        //    case 2: monthname = "February"; break;
        //    case 3: monthname = "March"; break;
        //    case 4: monthname = "April"; break;
        //    case 5: monthname = "May"; break;
        //    case 6: monthname = "June"; break;
        //    case 7: monthname = "July"; break;
        //    case 8: monthname = "August"; break;
        //    case 9: monthname = "September"; break;
        //    case 10: monthname = "October "; break;
        //    case 11: monthname = "November"; break;
        //    case 12: monthname = "December"; break;
        //    default: monthname = "WRONG "; break;



        //}
        //Console.WriteLine(monthname);


        //int i = 1;
        //int sumofodds = 0;
        //do
        //{
        //    if (i % 2 == 1)
        //    {
        //        sumofodds += i;
        //    }
        //    i++;

        //} while (i < 100);
        //Console.WriteLine("sum of odd numbers between 1 to 100 is : "+sumofodds);


        //int num1 = 6;
        //int fact = 1;
        //for (int i = num1; i > 1; i--)
        //{
        //    fact *= 1;
        //}
        //Console.WriteLine(fact);

        //int Number = 64351;
        //int value = 0;

        //while(Number>0)
        //{
        //    value += Number%10;
        //    Number = Number / 10;
        //}
        //Console.WriteLine("the total value is : "+value);


        //int number = 4;
        //int count = 0;

        //for (int i = 1; i <= number; i++)
        //{
        //    if(number%i == 0)
        //    { 
        //        count++; 
        //    }

        //}

        //if(count==2)
        //{
        //    Console.WriteLine(number + " is  prime number");
        //}
        //else
        //{
        //    Console.WriteLine(number + " is not a prime number");
        //}










    }      }
