using Tyuiu.NazarovAA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.NazarovAA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDeleteMiddleLetterValid()
        {
            DataService ds = new DataService();
            string result = ds.DeleteMiddleLetter("Hello tom how are you fine");
            string wait = "Helo tm hw ae yu fine";
            Assert.AreEqual(wait, result);
        }
    }
}
