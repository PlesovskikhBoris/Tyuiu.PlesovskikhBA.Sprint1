using Tyuiu.PlesovskikhBA.Sprint1.Task3.V18.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint1.Task3.V18
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Плесовских Борис Александрович | СМАРТб-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной C  *");
            Console.WriteLine("* можно разместить внутри прямоугольника с размерами A x B без наложений. *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double a;
            Console.WriteLine("Высота прямоугольника :                                                   *");
            a = Convert.ToInt32(Console.ReadLine());
            double b;
            Console.WriteLine("Ширина прямоугольника :                                                   *");
            b = Convert.ToInt32(Console.ReadLine());
            double c;
            Console.WriteLine("Сторона квадрата :                                                        *");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сколько квадратов влезает в прямоуголник: " + ds.HowManySquares(a, b, c));
            Console.ReadLine();

        }
    }
}