using Tyuiu.NazarovAA.Sprint1.Task7.V8.Lib;

namespace Tyuiu.NazarovAA.Sprint1.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculationValid()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(1, 2);
            double wait = 9.663;
            Assert.AreEqual(wait, result);
        }
    }
}
