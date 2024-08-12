namespace InterfaceTask;

 class Program
{
    private static void Main(string[] args)
    {
        

        Shop shop = new Shop();

        shop.proName = "Python Helmet";
        shop.price = "5000";
        shop.category = "Safety Purpose";
        shop.outName = "Axor";
        shop.city = "Chennai";
        shop.location = "Vadapalani";

        shop.getProductDetails();
        Console.WriteLine();
        shop.getOutletDetails();

        
    }
}