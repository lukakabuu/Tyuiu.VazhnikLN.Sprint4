using Tyuiu.VazhnikLN.Sprint4.Task6.V1.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            string[] m = { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            int res = ds.Calculate(m);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
