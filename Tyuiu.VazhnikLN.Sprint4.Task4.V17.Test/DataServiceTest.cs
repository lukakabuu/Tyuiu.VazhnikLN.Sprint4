using Tyuiu.VazhnikLN.Sprint4.Task4.V17.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int[,] matrix = {{4, 7, 4, 2, 1 },

                            { 6, 7, 3, 6, 5, },

                            { 6, 5, 3, 3, 5 },

                            { 4, 4, 6, 4, 7 },

                            { 2, 1, 2, 3, 4, } };
            int res = ds.Calculate(matrix);
            int wait = 54;
            Assert.AreEqual(wait, res);
        }
    }
}
