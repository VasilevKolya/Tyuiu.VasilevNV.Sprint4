using Tyuiu.VasilevNV.Sprint4.Task6.V5.Lib;
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
var week =new string[] { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };

;
Console.WriteLine("Исходный массив:");
for (int i = 0; i < week.Length - 1; i++)
{
    Console.WriteLine(week[i]);
}


Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
int res = ds.Calculate(week);
Console.WriteLine("Количество элементов длина которых - 7:");
Console.WriteLine(res);
Console.ReadLine();
