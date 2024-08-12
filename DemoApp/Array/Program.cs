internal class Program
{
    private static void Main(string[] args)
    {
        string[] weekends = { "sun", "mon", "tues", "wed", "thur", "fri", "sat" };

        foreach (string weekend in weekends)
            Console.WriteLine(weekend);

        //for (int i = 0; i < weekends.Length; i++)
        //{
        //    Console.WriteLine(weekends[i]);
        //}

        Console.WriteLine();

        Array.Sort(weekends);

        foreach(string weekend in weekends)

        Console.WriteLine("sorted array : " + weekend);

        Console.WriteLine();

        Array.Reverse(weekends);
        foreach(string day in  weekends)
            Console.WriteLine("reverse array :"+day);

        Console.WriteLine();

        string[] months = { "jan", "feb", "mar", "april", "may", "june", "july", "aug", "sep", "oct", "nov", "dec" };

        int monthposition = Array.IndexOf(months, "nov");
        Console.WriteLine("position of november : "+(monthposition+1));

        Console.WriteLine();
                                    Console.WriteLine("length : "+months.Length);

        Console.WriteLine();

        Array.Clear(months, 0, 2);

        foreach (string month in months) 
            Console.WriteLine("after clearing "+month);

        Console.WriteLine();

        Console.WriteLine("length : " + months.Length);
        Console.WriteLine();

        months[0] = "jan";
        Console.WriteLine("adding jan in array : ");
        foreach (string month in months)
            Console.WriteLine( month);

        Console.WriteLine();

        Array.Resize(ref months, 13);
        Console.WriteLine("length : " + months.Length);

        Console.WriteLine();

        string[] numbers = new string[10];

        weekends.CopyTo(numbers, 0);

        foreach (string number in numbers)
            Console.WriteLine(number);

    }
}