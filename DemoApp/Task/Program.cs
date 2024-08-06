
namespace Task;

 class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("enter first number: ");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("enter second number: ");
        int num2=int.Parse(Console.ReadLine());

        MathOperation m1=new MathOperation(num1,num2);

        m1.display();
    }
}