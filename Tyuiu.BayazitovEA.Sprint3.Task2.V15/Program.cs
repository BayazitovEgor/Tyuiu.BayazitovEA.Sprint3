using Tyuiu.BayazitovEA.Sprint3.Task2.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        double value = 0.5;
        int startValue = 1;
        int stopValue = 20;

        Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));
    }
}