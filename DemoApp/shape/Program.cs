using shape;
using System.Drawing;
using System.Runtime.CompilerServices;

class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("enter the length of rectangle : ");
        int length=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter the breadth of rectangle : ");
        int breadth=Convert.ToInt32(Console.ReadLine());
   
        Rect r = new Rect(length,breadth);

        r.formula();

        Console.WriteLine();

        Console.WriteLine("enter the side of square : ");
        int side=Convert.ToInt32(Console.ReadLine());

        Square s= new Square(side);

        s.formula();



    }
}