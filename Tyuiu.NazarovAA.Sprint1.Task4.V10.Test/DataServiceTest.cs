using Tyuiu.NazarovAA.Sprint1.Task4.V10.Lib;

namespace Tyuiu.NazarovAA.Sprint1.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculationValid()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(1);
            double wait = 2.175;
            Assert.AreEqual(wait, result);
        }
    }
}
