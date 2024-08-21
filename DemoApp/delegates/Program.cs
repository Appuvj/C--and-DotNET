
class delegates
{
    public void add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine("addition of " + a + "+" + b + "=" + c);
    }
    public void sub(int a, int b)
    {
        int c = a - b;
        Console.WriteLine("subtraction of " + a + "-" + b + "=" + c);
    }
    public void mul(int a, int b)
    {
        int c = a * b;
        Console.WriteLine("multiplication of " + a + "*" + b + "=" + c);
    }
}

public delegate void operation(int a, int b);


class Program
{
    private static void Main(string[] args)
    {

        operation op;

        delegates d= new delegates();

        op = d.add;
        op += d.sub;
        op+= d.mul;
        op(10, 5);


    }
}