using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VasilevNV.Sprint4.Task5.V9.Lib
{
    public class DataService : ISprint4Task5V9
    {
        public int Calculate(int[,] matrix)
        {
            if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 5)
                throw new ArgumentException("Массив должен быть размером 5x5");

            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
