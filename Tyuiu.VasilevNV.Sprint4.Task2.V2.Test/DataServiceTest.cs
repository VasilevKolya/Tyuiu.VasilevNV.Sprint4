using Tyuiu.VasilevNV.Sprint4.Task2.V2.Lib;
namespace Tyuiu.VasilevNV.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 2, 3, 5, 4, 1, 6, 7, 8, 3, 2, 1 };  
            int expected = 3 * 5 * 1 * 7 * 3 * 1;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }
    }
}