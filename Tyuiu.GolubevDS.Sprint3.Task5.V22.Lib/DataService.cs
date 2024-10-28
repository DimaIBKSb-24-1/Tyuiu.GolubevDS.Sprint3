namespace Tyuiu.GolubevDS.Sprint3.Task5.V22.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task5V22
{
    public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
    {
        double sum = 0;
        int i, k;

        for (i = startValue1; i <= stopValue1; i++)
        {
            for (k = startValue2; k <= stopValue2; k++)
            {
                sum += ((Math.Pow(x, 3) * Math.Sin(k)) + 2);
            }
        }

        return Math.Round(sum, 3);
    }
}
