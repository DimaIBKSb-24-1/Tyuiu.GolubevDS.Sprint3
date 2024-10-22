using Tyuiu.GolubevDS.Sprint3.Task0.V15.Lib;

DataService ds = new DataService();

Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                                  *");
Console.WriteLine("* Тема: Операции цикла for                                                                                   *");
Console.WriteLine("* Задание #0                                                                                                 *");
Console.WriteLine("* Вариант #15                                                                                                *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич  | ИБКСб-24-1                                                          *");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по формуле, при t = 0,7                *");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
Console.WriteLine("**************************************************************************************************************");

double value = 0.7;
int startValue = 1;
int endValue = 10;

Console.WriteLine("Переменая Х = " +  value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " +  endValue);
Console.WriteLine("Сумма ряда = " +ds.GetSumSeries(value, startValue, endValue)); 

Console.ReadLine();