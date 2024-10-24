namespace Tyuiu.GolubevDS.Sprint3.Task2.V25.Test;
using Tyuiu.GolubevDS.Sprint3.Task2.V25.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSeries()
    {
        DataService ds = new DataService();

        int value = 5;
        int startValue = 1;
        int stopValue = 13;

        double res = ds.GetSumSeries(value, startValue, stopValue);
        double wait = 16.016;
        Assert.AreEqual(res, wait);
    }
}