enum PaymentOptions
{
    CreditCard, DebitCard, NetBanking, Wallet
}
class Payment
{
    public string invoicename { get; set; }
    public PaymentOptions options;
    public static int noofpayments, paymentoptionscountC;
    static Payment()
    {
        noofpayments = 0;
        paymentoptionscountC = 0;
    }
    public Payment()
    {
        noofpayments += 1;
    }
    public void getPayementOptionWiseCount()
    {
        if (this.options == PaymentOptions.CreditCard)
        {
            paymentoptionscountC += 1;
        }
    }
}
class Program
{
    private static void Main(string[] args)
    {
        Payment p = new Payment();
        p.invoicename = "BroadBandBill";
        p.options = PaymentOptions.CreditCard;
        p.getPayementOptionWiseCount();
        Console.WriteLine(p.invoicename + " is paid by " + p.options);
        Payment p1 = new Payment();
        p1.invoicename = "AmazonShopping";
        p1.options = PaymentOptions.Wallet;
        p1.getPayementOptionWiseCount();
        Console.WriteLine(p1.invoicename + " is paid by " + p1.options);
        Payment p2 = new Payment();
        p2.invoicename = "AmazonShopping - 1";
        p2.options = PaymentOptions.NetBanking;
        p2.getPayementOptionWiseCount();
        Console.WriteLine(p1.invoicename + " is paid by " + p2.options);
        Console.WriteLine("No of Payment recieved: " + Payment.noofpayments);
        Console.WriteLine("No of times Credit Card Used: " + Payment.paymentoptionscountC);
    }
}