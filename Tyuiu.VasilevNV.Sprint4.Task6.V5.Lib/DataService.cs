using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VasilevNV.Sprint4.Task6.V5.Lib
{
    public class DataService : ISprint4Task6V5
    {
        public int Calculate(string[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int count = 0;
            foreach (string item in array)
            {
                if (item.Length == 5)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
     