using Tyuiu.NazarovAA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.NazarovAA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCylinderVolumeValid()
        {
            DataService ds = new DataService();
            Assert.AreEqual(62.832, ds.CylinderVolume(2, 5));
        }
    }
}
