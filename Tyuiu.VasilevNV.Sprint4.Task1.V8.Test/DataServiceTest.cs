using Tyuiu.VasilevNV.Sprint4.Task1.V8.Lib;
namespace Tyuiu.VasilevNV.Sprint4.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4 };
            int expected = 7 + 7 + 3 + 5 + 7;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }
    }
}