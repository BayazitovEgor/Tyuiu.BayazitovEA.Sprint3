using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BayazitovEA.Sprint3.Task4.V10.Lib
{
    public class DataService : ISprint3Task4V10
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sp = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                double y = (Math.Sin(x) - x) / x;
                sp = sp * y;
            }
            return Math.Round(sp, 3);
        }
    }
}
