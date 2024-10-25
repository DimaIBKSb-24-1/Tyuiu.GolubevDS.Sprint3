namespace Tyuiu.GolubevDS.Sprint3.Task4.V22.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task4V22
{
    public double Calculate(int startValue, int stopValue)
    {
        double result = 1;
        bool hasValues = false; 

        for (int x = startValue; x <= stopValue; x++)
        {
            if (x == 0)
            {
                continue; 
            }
            else
            {
                double value = x / (Math.Sin(x) - x);
                result *= value; 

                hasValues = true; 
            }
        }

        return hasValues ? Math.Round(result, 3) : 0;
    }
}
