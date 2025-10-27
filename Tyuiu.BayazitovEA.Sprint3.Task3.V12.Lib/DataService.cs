using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BayazitovEA.Sprint3.Task3.V12.Lib
{
    public class DataService : ISprint3Task3V12
    {
        public int GetMaxCharCount(string value, char item)
        {
            int maxConsecutiveK = 0;
            int currentConsecutiveK = 0;
            foreach (char c in value)
            {
                if (c == item)
                {
             
                    currentConsecutiveK++;
                    if (currentConsecutiveK > maxConsecutiveK)
                    {
                        maxConsecutiveK = currentConsecutiveK;
                    }
                }
                else
                {
                    currentConsecutiveK = 0;
                }
            }
            return maxConsecutiveK;
        }
            
    }
}
