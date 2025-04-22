using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            Converter converter = new Converter(3.2, 3.5, 0.034);

            Console.WriteLine("Конвертер валют BYN <-> USD, EUR, RUB");

            Console.Write("Выберите направление (1 - BYN в валюту, 2 - Валюта в BYN): ");
            string choice = Console.ReadLine();

            Console.Write("Введите валюту (USD, EUR, RUB): ");
            string currency = Console.ReadLine();

            Console.Write("Введите сумму: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            if (choice == "1")
            {
                result = converter.ConvertFromBYN(currency, amount);
                Console.WriteLine("{0} BYN = {1:F2} {2}", amount, result, currency.ToUpper());
            }
            else if (choice == "2")
            {
                result = converter.ConvertToBYN(currency, amount);
                Console.WriteLine("{0} {1} = {2:F2} BYN", amount, currency.ToUpper(), result);
            }
            else
            {
                Console.WriteLine("Неверный выбор направления.");
            }

            Console.ReadKey();

        }
    }
}
