using Tyuiu.GolubevDS.Sprint3.Task5.V22.Lib;
DataService ds = new DataService();

Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                                  *");
Console.WriteLine("* Тема: Вложенные циклы                                                                                 *");
Console.WriteLine("* Задание #5                                                                                                 *");
Console.WriteLine("* Вариант #22                                                                                                *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич  | ИБКСб-24-1                                                          *");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение ряда по формуле, при a=2           *");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
Console.WriteLine("**************************************************************************************************************");

int x = 2;
int startValue1 = 1;
int startValue2 = 1;
int stopValue1 = 3;
int stopValue2 = 12;

Console.WriteLine("Переменая X = " + x);
Console.WriteLine("Старт первого шага = " + startValue1);
Console.WriteLine("Конец первого шага = " + stopValue1);
Console.WriteLine("Старт второго шага = " + startValue2);
Console.WriteLine("Конец второго шага = " + stopValue2);

Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

Console.ReadLine();
