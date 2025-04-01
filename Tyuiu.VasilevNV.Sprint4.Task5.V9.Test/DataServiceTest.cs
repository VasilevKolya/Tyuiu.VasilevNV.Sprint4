using Tyuiu.VasilevNV.Sprint4.Task5.V9.Lib;
namespace Tyuiu.VasilevNV.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] {
                                     { 1, -1,  2,  0, -2},
                                    { 3,  0, -3,  4, -4},
                                    { 2, -2,  1, -1,  0},
                                    { 4, -4,  3, -3,  2},
                                    { 0,  1, -2,  2, -1} };
            int res = ds.Calculate(array);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}
