using Tyuiu.VasilevNV.Sprint4.Task1.V8.Lib;
DataService ds = new DataService();
Console.WriteLine("*Спринт #4 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #4                                                             *");
Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                         *");
Console.WriteLine("* Задание #1                                                            *");
Console.WriteLine("* Вариант #8                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Дан одномерный целочисленный массив на 12 элементов заполненный значениями *");
Console.WriteLine("с клавиатуры в диапазоне от 2 до 9 подсчитать сумму нечетных элементов массива*");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
Console.WriteLine("Исходный массив:");
for (int i = 0; i < 12; i++)
{
    Console.WriteLine(numsArray[i] + "\t");
}


Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
int res = ds.Calculate(numsArray);
Console.WriteLine(res);

Console.ReadLine();

