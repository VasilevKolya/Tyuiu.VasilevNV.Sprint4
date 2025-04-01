using Tyuiu.VasilevNV.Sprint4.Task4.V17.Lib;
DataService ds = new DataService();
Console.WriteLine("*Спринт #4 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #4                                                             *");
Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                           *");
Console.WriteLine("* Задание #2                                                            *");
Console.WriteLine("* Вариант #6                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими  *");
Console.WriteLine(" значениями в диапазоне от 3 до 8. Найдите максимальный элемент во второй строке массива. *");
Console.WriteLine("*                                                                       *");
int[,] array = new int[5, 5] {
                                    { 2, 3, 2, 4, 3 },
                                     { 4, 7, 4, 2, 2 },
                                        { 5, 2, 3, 4, 6 },
                                        { 5, 2, 7, 6, 5 },
                                        { 6, 3, 5, 7, 7 } };
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
