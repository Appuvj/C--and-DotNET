using System.Runtime.CompilerServices;

class Program
{
    private static void Main(string[] args)
    {
        //List <int> numbers = new List<int> { 10,15,20,60,78,11,13,22,99};
        //List<int> evenList = new List<int>();

        //evenList=(from list in numbers where(list%2==0) select list).ToList();

        //foreach(int i in evenList)
        //{
        //    Console.WriteLine(i);
        //}



        List<string> list = new List<string> { "butter","milk","oil","choculate","biscuit","icecream","juice"};
        List<string> searchList = new List<string> { };

        Console.WriteLine("The List");
        Console.WriteLine();
        foreach (string s in list) 
        {
            Console.WriteLine(s);
        }

        Console.WriteLine();

        Console.WriteLine("enter the product you want to find : ");
        string product=Console.ReadLine();

        searchList = (from items in list where (items.Equals(product))select items).ToList();

        if (list.Contains(product))
        {
            foreach (string s in searchList)
            { Console.WriteLine(s + " product is available in list"); }
        }
        else
        {
            Console.WriteLine("Product is not available in List");
        }

    }
}