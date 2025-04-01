using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VasilevNV.Sprint4.Task3.V6.Lib
{
    public class DataService : ISprint4Task3V6
    {
        public int Calculate(int[,] array)
        {
            if (array.GetLength(0) < 2 || array.GetLength(1) != 5)
                throw new ArgumentException("Массив должен быть 5x5.");

            int max = array[1, 0]; 

            for (int j = 1; j < 5; j++)
            {
                if (array[1, j] > max)
                    max = array[1, j];
            }

            return max;
        }
    }
}
     