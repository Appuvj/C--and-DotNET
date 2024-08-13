using System.Diagnostics;

class Program
{
    private static void Main(string[] args)
    {
        List<string> products = new List<string>() { "Butter", "Cheese", "Milk" };
        List<int> prices = new List<int>() { 100, 80, 50 };

        Console.WriteLine("Product List");
        Console.WriteLine();
        Console.Write("product name  ");
        Console.Write("price");
        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine(products[i] + "          " + prices[i]);

        }

        for (int choice = 0; choice <= 4; choice++)
        {

            Console.WriteLine();

            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Update Product");
            Console.WriteLine("3.Remove Product");
            Console.WriteLine("4.Show the List");
            Console.WriteLine();

            Console.WriteLine("Enter your choice : ");

             choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the product you want to add : ");
                string add = Console.ReadLine();
                Console.WriteLine("enter the price you want to add : ");
                int price = Convert.ToInt32(Console.ReadLine());

                products.Add(add);
                prices.Add(price);

                Console.WriteLine("you want to add more products: ");
                string flag = Console.ReadLine();

                if (flag == "Y" || flag == "y")
                {
                    while (flag == "Y" || flag == "y")
                    {
                        Console.WriteLine("Enter the product you want to add : ");
                        add = Console.ReadLine();
                        Console.WriteLine("enter the price you want to add : ");
                        price = Convert.ToInt32(Console.ReadLine());

                        products.Add(add);
                        prices.Add(price);

                        Console.WriteLine("you want to add more products: ");
                        flag = Console.ReadLine();

                    }
                }
                else
                {
                    Console.WriteLine("Thank You");
                }

            }

            else if (choice == 2)
            {
                Console.WriteLine("Enter the product you want to update");
                string update = Console.ReadLine();

                if (products.Any(p => p.Equals(update, StringComparison.OrdinalIgnoreCase)))
                {
                    int index = products.FindIndex(p => p.Equals(update, StringComparison.OrdinalIgnoreCase));

                    Console.WriteLine("Enter the new product: ");
                    string newProd = Console.ReadLine();
                    Console.WriteLine("enter the price you want to add : ");
                   int price = Convert.ToInt32(Console.ReadLine());

                    products[index] = newProd;
                    prices[index] = price;

                    Console.WriteLine("Products added successfully");

                }
                else
                {
                    Console.WriteLine("Product is not available in the list");
                }
            }

            else if (choice == 3)
            {
                Console.WriteLine("Enter the product you want to remove");
                string remove = Console.ReadLine();

                if (products.Contains(remove))
                {

                    products.Remove(remove);
                    Console.WriteLine("Product removed successfully");
                }
                else
                {
                    Console.WriteLine("Product is not available in the list");
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Product List");
                Console.WriteLine();
                Console.Write("Product_Name    ");
                Console.Write("price");
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine(products[i] + "            " + prices[i]);
                }
            }

            else
            {
                Console.WriteLine("Invalid Choice");
            }

        }
    }
}