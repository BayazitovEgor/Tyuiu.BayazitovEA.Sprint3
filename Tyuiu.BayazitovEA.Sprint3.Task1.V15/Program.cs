using Tyuiu.BayazitovEA.Sprint3.Task1.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int value = 2;
        int startValue = 1;
        int stopValue = 5;

        Console.WriteLine( ds.GetMultiplySeries(value, startValue, stopValue));
    }
}