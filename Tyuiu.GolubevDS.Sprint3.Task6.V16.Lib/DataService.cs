namespace Tyuiu.GolubevDS.Sprint3.Task6.V16.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task6V16
{
    public int GetSumTheDivisors(int startValue, int stopValue)
    {
        int totalDivisorCount = 0; 

        for (int x = startValue; x <= stopValue; x++)
        {
            int divisorCount = 0; 
            for (int d = 1; d <= x; d++)
            {
                if (x % d == 0) 
                {
                    divisorCount++; 
                }
            }
            totalDivisorCount += divisorCount; 
        }

        return totalDivisorCount;
    }
}
