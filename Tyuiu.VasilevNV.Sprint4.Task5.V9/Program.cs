using Tyuiu.VasilevNV.Sprint4.Task5.V9.Lib;
DataService ds = new DataService();
Console.WriteLine("*Спринт #4 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #4                                                             *");
Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                  *");
Console.WriteLine("* Задание #5                                                            *");
Console.WriteLine("* Вариант #9                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными *");
Console.WriteLine("значениями в диапазоне от -4 до 4. Найти количество положительных элементов.*");
Console.WriteLine("*                                                                       *");
int[,] array = new int[5, 5] {
                                   { 1, -1,  2,  0, -2},
                                    { 3,  0, -3,  4, -4},
                                    { 2, -2,  1, -1,  0},
                                    { 4, -4,  3, -3,  2},
                                    { 0,  1, -2,  2, -1} };
int rows = array.GetUpperBound(0) + 1;
int colums = array.Length / rows;
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("Массив");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.WriteLine($"{array[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
int res = ds.Calculate(array);
Console.WriteLine("Максимальный элеммент в строке:" + res);

Console.ReadKey();
