using Tyuiu.BayazitovEA.Sprint3.Task4.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine(ds.Calculate(startValue, stopValue));
    }
}