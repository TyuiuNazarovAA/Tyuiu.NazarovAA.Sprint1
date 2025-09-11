using Tyuiu.NazarovAA.Sprint1.Task0.V5.Lib;

namespace Tyuiu.NazarovAA.Sprint1.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculationValid()
        {
            DataService ds = new DataService();
            double result = ds.Calculate();
            Assert.AreEqual(12, result);
        }
    }
}
