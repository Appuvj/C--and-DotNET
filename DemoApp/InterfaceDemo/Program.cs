using InterfaceDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Company company = new Company();

        company.Name = "Changepond Technologies";
        company.addressline1 = "siruseri,Navalur";
        company.state = "Tamil Nadu";
        company.city = "Chennai";
        company.postcode = "600073";
        company.mobile = 0448552962;
        company.email = "changepond@gmail.com";

        company.addressDetails();
        Console.WriteLine();
        company.getContactDetails();
    
        Console.WriteLine();
        Console.WriteLine();

        Employee employee = new Employee();

        employee.name = "vijay kumar";
        employee.addressline1 = "sembakkam";
        employee.state = "TamilNadu";
        employee.city = "Chennai";
        employee.postcode = "600126";
        employee.mobile = 8668113093;
        employee.email = "vijay@gmail.com";

        employee.addressDetails();
        Console.WriteLine();
        employee.getContactDetails();
    }
}