using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VasilevNV.Sprint4.Task7.V13.Lib
{
    public class DataService : ISprint4Task7V13
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[3, 3];
            int evenCount = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = (int)(value[i * 3 + j] - '0'); 
                    if (matrix[i, j] % 2 == 0) 
                    {
                        evenCount++;
                    }
                }
            }

            
            return evenCount;
        }
    }
}
    