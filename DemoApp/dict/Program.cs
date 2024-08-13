

class Program
{
    private static void Main(string[] args)
    {
        //Dictionary<string,int>score=new Dictionary<string, int>();
        //score.Add("vijay",450);
        //score.Add("karupu", 460);
        //score.Add("hamsa", 500);

        //Console.WriteLine(score["vijay"]);

        //foreach (string s in score.Keys)
        //{
        //    Console.WriteLine(s +"  "+score[s]);

        //}

        SortedList<string, int> report = new SortedList<string, int>();
        report.Add("vijay", 450);
        report.Add("karupu", 460);
        report.Add("hamsa", 500);

        foreach (string s in report.Keys)
        {
            Console.WriteLine(s+" " + report[s]); 
            
        }


        Dictionary<string,int> list=new Dictionary<string,int>();

        list.Add("maths", 90);
        list.Add("physics", 80);
        list.Add("abacus", 100);

        foreach(string s in list.Keys)
        {
            Console.WriteLine(s+" " + list[s]);
        }




    }
}