namespace Tyuiu.GolubevDS.Sprint3.Task1.V25.Test;
using Tyuiu.GolubevDS.Sprint3.Task1.V25.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetMultiplySeries()
    {
        DataService ds = new DataService();

        int value = 2;
        int startValue = 1;
        int stopValue = 6;
         
        double res = ds.GetMultiplySeries(value, startValue, stopValue);
        double wait = 1092.543;

        Assert.AreEqual(res, wait);

    }
}