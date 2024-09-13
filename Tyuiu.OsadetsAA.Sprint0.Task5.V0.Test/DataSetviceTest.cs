using Tyuiu.OsadetsAA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.OsadetsAA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataSetviceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(15, 5));
        }
        public void CheckMultiplicationValid2()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        public void CheckDivisionValid3()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}