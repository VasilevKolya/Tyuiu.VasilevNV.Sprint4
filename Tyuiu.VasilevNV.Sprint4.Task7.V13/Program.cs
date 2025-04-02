using System.Diagnostics;
using Tyuiu.VasilevNV.Sprint4.Task7.V13.Lib;
DataService ds = new DataService();
int rows = 3;
int colums = 3;
string input = "159357246";
Console.WriteLine("*Спринт #4 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #4                                                             *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту               *");
Console.WriteLine("* Задание #7                                                            *");
Console.WriteLine("* Вариант #13                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Дана строка из одноразрядных цифр \"159357246\". Преобразуйте ее         *");
Console.WriteLine("в матрицу 3 на 3 и подсчитайте количество четных чисел.                  *");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
int index = 0;
Console.WriteLine("\nМассив");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.WriteLine($"{input[index]}\t");
        index++;
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("*************************************************************************");
    Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
    Console.WriteLine("*************************************************************************");
    int result = ds.Calculate(rows, colums, input);
    Console.WriteLine($"Количество четных чисел в матрице: {result}");
    Console.ReadKey();

