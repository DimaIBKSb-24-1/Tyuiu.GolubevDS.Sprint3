namespace Tyuiu.GolubevDS.Sprint3.Task5.V22.Test;
using Tyuiu.GolubevDS.Sprint3.Task5.V22.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSumSeries()
    {
        DataService ds = new DataService();
        int x = 2;
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 3;
        int stopValue2 = 12;

        double wait = 68.991;

        double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);


        Assert.AreEqual(wait , res);
    }
}