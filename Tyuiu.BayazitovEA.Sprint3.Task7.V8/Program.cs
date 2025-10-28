using Tyuiu.BayazitovEA.Sprint3.Task7.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = -5;
        int stopValue = 5;
        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] results;
        results = new double[len];

        results = ds.GetMassFunction(startValue, stopValue);

        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}   |    {1, 5:f2}   |",startValue, results[i]);
            startValue++;
        }
    }
}