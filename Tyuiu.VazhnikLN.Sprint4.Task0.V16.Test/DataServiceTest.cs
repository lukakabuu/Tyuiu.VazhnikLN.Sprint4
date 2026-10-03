using Tyuiu.VazhnikLN.Sprint4.Task0.V16.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] s = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int wait = 3072;
            int res = ds.GetMultEvenArrEl(s);
            Assert.AreEqual(wait, res);
        }
    }
}
