namespace Tyuiu.GolubevDS.Sprint3.Task6.V16.Test;
using Tyuiu.GolubevDS.Sprint3.Task6.V16.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumTheDivisors()
    {
        DataService ds = new DataService();
        int startValue = 5;
        int stopValue = 16;
        int res = ds.GetSumTheDivisors(startValue, stopValue);
        int wait = 205;
        Assert.AreEqual(res, wait);
    }
}