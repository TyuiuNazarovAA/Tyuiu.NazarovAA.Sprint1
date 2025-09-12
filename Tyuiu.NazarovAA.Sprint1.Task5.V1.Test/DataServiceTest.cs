using Tyuiu.NazarovAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.NazarovAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculationValid()
        {
            DataService ds = new DataService();
            int result = ds.DistanceBetweenDots(2, 3, 5, 8);
            int wait = 6;
            Assert.AreEqual(wait, result);
        }
    }
}
