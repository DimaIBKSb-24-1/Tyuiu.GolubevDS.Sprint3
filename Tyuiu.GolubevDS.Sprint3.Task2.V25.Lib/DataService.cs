namespace Tyuiu.GolubevDS.Sprint3.Task2.V25.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task2V25
{
    public double GetSumSeries(int value, int startValue, int stopValue)
    {
        double SumSeries = 0;
        while (startValue <= stopValue)
        {
            SumSeries += Math.Pow(4 / Math.Pow(startValue, value), 2);
            startValue++; 
        }

        return Math.Round(SumSeries, 3);
    }
}
