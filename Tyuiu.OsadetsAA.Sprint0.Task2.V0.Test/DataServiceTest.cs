using Tyuiu.OsadetsAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.OsadetsAA.Sprint0.Task2.V0.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckGetMessageValid()
    {
        var name = "Александр";
        var res = DataService.GetMessage(name);
        Assert.AreEqual("Привет, Александр", res);
    }
}