using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura f = new Figura();

            Console.WriteLine("Выберите фигуру:");
            Console.WriteLine("1 - Квадрат\n2 - Прямоугольник\n3 - Трапеция");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите сторону квадрата: ");
                    double side = double.Parse(Console.ReadLine());
                    f.ShowArea(side);
                    break;

                case "2":
                    Console.Write("Введите длину: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Введите ширину: ");
                    double width = double.Parse(Console.ReadLine());
                    f.ShowArea(length, width);
                    break;

                case "3":
                    Console.Write("Введите основание 1: ");
                    double base1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите основание 2: ");
                    double base2 = double.Parse(Console.ReadLine());
                    Console.Write("Введите высоту: ");
                    double height = double.Parse(Console.ReadLine());
                    f.ShowArea(base1, base2, height);
                    break;

                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
