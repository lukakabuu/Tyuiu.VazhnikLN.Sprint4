using Tyuiu.VazhnikLN.Sprint4.Task7.V10.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string m = "695847142536";
            int n = 3;
            int c = 4;
            int res = ds.Calculate(n, c, m);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
