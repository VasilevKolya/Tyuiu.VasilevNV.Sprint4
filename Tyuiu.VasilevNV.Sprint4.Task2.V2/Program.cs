using Tyuiu.VasilevNV.Sprint4.Task2.V2.Lib;
DataService ds = new DataService();
Console.WriteLine("*Спринт #4 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #4                                                             *");
Console.WriteLine("* Тема: дномерные массивы. (генератор случайных чисел)                  *");
Console.WriteLine("* Задание #2                                                            *");
Console.WriteLine("* Вариант #2                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Дан одномерный целочисленный массив на 11 элементов заполненный случайными *");
Console.WriteLine("в диапазоне от 1 до 8 подсчитать произведение нечетных элементов массива.*");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
int[] numsArray = { 2, 3, 5, 4, 1, 6, 7, 8, 3, 2, 1 };
Console.WriteLine("Исходный массив:");
for (int i = 0; i < 11; i++)
{
    Console.WriteLine(numsArray[i] + "\t");
}


Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
int res = ds.Calculate(numsArray);
Console.WriteLine("Произведение нечетных чисел:" + res);

Console.ReadLine();
