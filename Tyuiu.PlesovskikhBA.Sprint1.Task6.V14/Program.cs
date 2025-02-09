//Написать программу: пользователь вводит текст. Проверить, что строка составлена только из строчных русских букв.
using Tyuiu.PlesovskikhBA.Sprint1.Task6.V14.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint1.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Плесовских Б. А. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Плесовских Борис Александрович | СМАРТб-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу:                                                     *");
            Console.WriteLine("* пользователь вводит текст. Проверить, что строка составлена             *");
            Console.WriteLine("* только из строчных русских букв.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Все ли буквы строчные? :                                                  *");
            string text = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Ответ: " + ds.CheckLowerCaseRusLetters(text));
            Console.ReadLine();
        }
    }
}
