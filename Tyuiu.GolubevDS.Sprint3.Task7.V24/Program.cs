using Tyuiu.GolubevDS.Sprint3.Task7.V24.Lib;
DataService ds = new DataService();

Console.WriteLine("****************************************************************************************");
Console.WriteLine("* Спринт #3                                                                            *");
Console.WriteLine("* Тема:  алгоритмы циклической структуры                                               *");
Console.WriteLine("* Задание #7                                                                           *");
Console.WriteLine("* Вариант #24                                                                          *");
Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИБКСб 24-1                                     *");
Console.WriteLine("****************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                             *");
Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции                         *");
Console.WriteLine("* F(x) = sin(x)/(x+1,2) - sin(x)*2 - 2x                                                *");
Console.WriteLine("****************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
Console.WriteLine("****************************************************************************************");


int startValue = -5;
int stopValue = 5;

Console.WriteLine("Старт шага: " + startValue);
Console.WriteLine("Стоп шага: " + stopValue);

int len = ds.GetMassFunction(startValue, stopValue).Length;
double[] valueArray;
valueArray = new double[len];
valueArray = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("+----------+----------+");
Console.WriteLine("|    X     |   f(x)   |");
Console.WriteLine("+----------+----------+");
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("|{0,5:d}     |{1, 6:f2}    |", startValue, valueArray[i]);
    Console.WriteLine("+----------+----------+");
    startValue++;
}
Console.ReadKey();