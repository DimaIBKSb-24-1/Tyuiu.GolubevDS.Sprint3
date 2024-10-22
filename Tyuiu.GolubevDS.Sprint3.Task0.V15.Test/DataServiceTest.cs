namespace Tyuiu.GolubevDS.Sprint3.Task0.V15.Test;
using Tyuiu.GolubevDS.Sprint3.Task0.V15.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSeries()
    {
        DataService ds = new DataService();
        double value = 0.7;
        int startValue = 1;
        int stopValue = 10;

        double res = ds.GetSumSeries(value, startValue, stopValue);
        double wait = 4.063;
        Assert.AreEqual(res, wait);

    }
}