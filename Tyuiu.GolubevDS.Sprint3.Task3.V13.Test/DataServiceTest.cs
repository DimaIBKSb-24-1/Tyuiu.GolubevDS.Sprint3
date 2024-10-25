namespace Tyuiu.GolubevDS.Sprint3.Task3.V13.Test;
using Tyuiu.GolubevDS.Sprint3.Task3.V13.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidConvertStringToInt()
    {
        DataService ds = new DataService();

        string str = "?sd!! 5gh. s!";
        char chr = '5';
        double res = ds.ConvertStringToInt(str);
        int wair = 5;

        Assert.AreEqual(res, wair);
    }
}