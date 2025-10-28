using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BayazitovEA.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            int len  = (stopValue - startValue) + 1;
            double[] results ;

           results = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x), 2);
                results[count] = y;
                count++;
            }

            return results;
        }

       
    }
    }

