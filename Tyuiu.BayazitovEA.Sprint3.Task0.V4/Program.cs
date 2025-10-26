using Tyuiu.BayazitovEA.Sprint3.Task0.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = 1;
        int stopValue = 8;

        Console.WriteLine( ds.GetMultiplySeries(startValue, stopValue));




    }
}