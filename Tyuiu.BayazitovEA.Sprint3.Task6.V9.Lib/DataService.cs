using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BayazitovEA.Sprint3.Task6.V9.Lib
{
    public class DataService : ISprint3Task6V9
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int countDivisors = 0;

            for (int x = startValue; x <= stopValue; x++)
            {


                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        countDivisors++;
                    }
                }

                
            }
            return countDivisors;
        }
    }
}
