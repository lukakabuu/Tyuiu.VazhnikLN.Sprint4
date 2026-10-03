using Tyuiu.VazhnikLN.Sprint4.Task2.V23.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] s = { 2, 2, 0, 9, 15, 14 };
            int res = ds.Calculate(s);
            int wait = 18;
            Assert.AreEqual(wait, res);
        }
    }
}
