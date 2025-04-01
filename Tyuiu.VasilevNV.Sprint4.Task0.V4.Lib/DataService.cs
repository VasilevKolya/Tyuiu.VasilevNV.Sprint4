using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VasilevNV.Sprint4.Task0.V4.Lib
{
    public class DataService : ISprint4Task0V4
    {
        public int GetMultEvenArrEl(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив не может быть null или пустым");

            int product = 1;
            bool hasEvenElements = false;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    product *= num;
                    hasEvenElements = true;
                }
            }

            return hasEvenElements ? product : 0;
        }
    }
}
   