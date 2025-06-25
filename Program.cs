using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое число: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Выберите операцию (+, -, *, /): ");
                string op = Console.ReadLine();

                double result = 0;
                switch (op)
                {
                    case "+": result = Calculator.Add(a, b); break;
                    case "-": result = Calculator.Sub(a, b); break;
                    case "*": result = Calculator.Mul(a, b); break;
                    case "/": result = Calculator.Div(a, b); break;
                    default: Console.WriteLine("Неизвестная операция."); return;
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
