using Tyuiu.BayazitovEA.Sprint3.Task6.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = 19;
        int stopValue = 30;

        Console.WriteLine(ds.GetSumTheDivisors( startValue, stopValue));
    }
}