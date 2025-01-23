using Tyuiu.PlesovskikhBA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Плесовских Б. А. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Плесовских Борис Александрович | СМАРТб-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до     *");
            Console.WriteLine("* того момента (в первой половине дня), когда того момента                *");
            Console.WriteLine("* (в первой половине дня), когда часовая стрелка повернулась на           *");
            Console.WriteLine("* f градусов (0<f<360, f – вещественное число).                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("На сколько градусов повернута стрелка :                                   *");
            double angle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Время на часах(в часах): " + Convert.ToInt32(ds.AngleToHoursMinutes(angle)));
            Console.ReadLine();
        }
    }
}