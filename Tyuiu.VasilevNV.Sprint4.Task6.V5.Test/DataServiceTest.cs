using Tyuiu.VasilevNV.Sprint4.Task6.V5.Lib;
namespace Tyuiu.VasilevNV.Sprint4.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] Array = ["Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун"];
            int res = ds.Calculate(Array);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}