using Tyuiu.NazarovAA.Sprint1.Task1.V30.Lib;

namespace Tyuiu.NazarovAA.Sprint1.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculationValid()
        {
            DataService ds = new DataService();
            Assert.AreEqual(3, ds.Calculate(4));
        }
    }
}
