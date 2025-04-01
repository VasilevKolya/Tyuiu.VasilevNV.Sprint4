using Tyuiu.VasilevNV.Sprint4.Task0.V4.Lib;
namespace Tyuiu.VasilevNV.Sprint4.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           DataService ds = new DataService();
            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int expected = 8 * 4; // 32

            int result =ds.GetMultEvenArrEl(array);

            Assert.AreEqual(expected, result);
        }
    }
}