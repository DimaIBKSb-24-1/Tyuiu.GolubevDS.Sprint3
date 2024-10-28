using Tyuiu.GolubevDS.Sprint3.Task6.V16.Lib;
DataService ds = new DataService();

Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                                  *");
Console.WriteLine("* Тема: Обработка целочисленной информации                                                                   *");
Console.WriteLine("* Задание #6                                                                                                 *");
Console.WriteLine("* Вариант #16                                                                                                *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич  | ИБКСб-24-1                                                          *");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [5, 16]                *");
Console.WriteLine("* количество всех делителей                                                                                  *");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
Console.WriteLine("**************************************************************************************************************");

int startValue = 5;
int stopValue = 16;

Console.WriteLine("Начало отрезка = " + startValue);
Console.WriteLine("Конец отрезка = " + stopValue);

Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

Console.ReadLine();

