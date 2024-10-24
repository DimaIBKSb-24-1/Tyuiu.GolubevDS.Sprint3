using Tyuiu.GolubevDS.Sprint3.Task2.V25.Lib;
DataService ds = new DataService();

Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                                  *");
Console.WriteLine("* Тема: Операции цикла do while                                                                              *");
Console.WriteLine("* Задание #0                                                                                                 *");
Console.WriteLine("* Вариант #15                                                                                                *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич  | ИБКСб-24-1                                                          *");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
Console.WriteLine("* Написать программу используя цикл do while, которая вычисляет произведение ряда по формуле, при n=5        *");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
Console.WriteLine("**************************************************************************************************************");

int value = 5;
int startValue = 1;
int endValue = 13;

Console.WriteLine("Переменая А = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + endValue);

Console.WriteLine("Произведение ряда = " + ds.GetSumSeries(value, startValue, endValue));

Console.ReadLine();
