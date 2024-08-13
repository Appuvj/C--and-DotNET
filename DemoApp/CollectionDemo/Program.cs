

using CollectionDemo;
using System.Net.NetworkInformation;

class Program
{
    private static void Main(string[] args)
    {
        Product p1, p2, p3, p4;

        p1 = new Product { Id = 1,Name="pizza",Price=200 };
        p2 = new Product { Id = 2, Name = "Burger", Price = 300 };
        p3 = new Product { Id = 3, Name = "coke", Price = 150 };
        p4 = new Product { Id = 4, Name = "moosecake", Price = 250 };

        List<Product>p=new List<Product> { p1,p2,p3,p4};
        List<Product> cart = new List<Product>();


        Console.WriteLine("the total bill");
        Console.WriteLine();
        for (int i=0;i<p.Count;i++)
        {

            Product pro = p[i];

            Console.WriteLine(pro.Id +" "+ pro.Name +" "+ pro.Price);
            Console.WriteLine();

            if(pro.Price>=200)
            {
                cart.Add(pro);
            }


        }
        Console.WriteLine("price greater than 200");
        Console.WriteLine();


        //for (int i = 0; i < p.Count; i++)
        //{


        //    if (p[i].Price >= 200)
        //    {
        //        Console.WriteLine(p[i].Id + " " + p[i].Name + " " + p[i].Price);
        //    }
        //}

        for (int i = 0; i < cart.Count; i++)
        {
            Product c= cart[i];
            Console.WriteLine(c.Id + " " + c.Name + " " + c.Price);
        }





    }
}