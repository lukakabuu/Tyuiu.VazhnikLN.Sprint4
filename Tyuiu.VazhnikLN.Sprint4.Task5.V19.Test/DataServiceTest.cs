using Tyuiu.VazhnikLN.Sprint4.Task5.V19.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = {{4, 7, 4, 2, 1 },

                            { -2, 7, 3, -3, 5, },

                            { 6, 5, 3, 3, 5 },

                            { 4, 4, 6, 4, -1 },

                            { 2, 1, 2, 3, 4, } };
            int res = ds.Calculate(matrix);
            int wait = 22;
            Assert.AreEqual(wait, res);
        }
    }
}
