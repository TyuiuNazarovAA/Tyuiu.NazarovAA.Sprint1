using Tyuiu.NazarovAA.Sprint1.Task2.V7.Lib;

namespace Tyuiu.NazarovAA.Sprint1.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculationValid()
        {
            DataService ds = new DataService();
            Assert.AreEqual(12.566, ds.CalculateSquareCircle(2));
        }
    }
}
