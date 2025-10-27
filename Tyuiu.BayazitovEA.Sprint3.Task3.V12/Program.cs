using Tyuiu.BayazitovEA.Sprint3.Task3.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string value = "bkkrk ckkkcs ksr";
        char item = 'k';



        Console.WriteLine(ds.GetMaxCharCount(value, item));
    }
}