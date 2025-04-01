using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VasilevNV.Sprint4.Task2.V2.Lib
{
    public class DataService : ISprint4Task2V2
    {
        public int Calculate(int[] array)
        {
            if (array == null || array.Length != 11)
                throw new ArgumentException("Массив должен содержать ровно 11 элементов");

            int product = 1;
            bool hasOddElements = false;

            foreach (int num in array)
            {
                if (num < 1 || num > 8)
                    throw new ArgumentException("Элементы массива должны быть в диапазоне 1-8");

                if (num % 2 != 0)
                {
                    product *= num;
                    hasOddElements = true;
                }
            }

            return hasOddElements ? product : 0;
        }
    }
}