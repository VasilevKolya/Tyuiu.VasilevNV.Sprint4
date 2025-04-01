using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VasilevNV.Sprint4.Task1.V8.Lib
{
    public class DataService : ISprint4Task1V8
    {
        public int Calculate(int[] array)
        {
            if (array == null || array.Length != 12)
                throw new ArgumentException("Массив должен содержать ровно 12 элементов");

            int sum = 0;

            foreach (int num in array)
            {
                if (num < 2 || num > 9)
                    throw new ArgumentException("Элементы массива должны быть в диапазоне 2-9");

                if (num % 2 != 0)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
      