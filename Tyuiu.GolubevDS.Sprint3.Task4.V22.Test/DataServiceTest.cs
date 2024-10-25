namespace Tyuiu.GolubevDS.Sprint3.Task4.V22.Test;
using Tyuiu.GolubevDS.Sprint3.Task4.V22.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;

        double res = ds.Calculate(startValue, stopValue);

        double wait = 73.346;
        Assert.AreEqual(res, wait);
    }
}