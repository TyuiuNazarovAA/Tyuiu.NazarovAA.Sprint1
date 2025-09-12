using Tyuiu.NazarovAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.NazarovAA.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Назаров А. А. | РППб 25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Назаров Артём Александрович | СППб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X1:");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y1:");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение X2:");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y2:");
            double y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.DistanceBetweenDots(x1, y1, x2, y2));
        }
    }
}
