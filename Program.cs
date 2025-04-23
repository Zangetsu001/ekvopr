using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер счёта:");
            int account = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите имя покупателя:");
            string customer = Console.ReadLine();

            Console.WriteLine("Введите имя поставщика:");
            string provider = Console.ReadLine();

            Invoice invoice = new Invoice(account, customer, provider);

            Console.WriteLine("Введите название товара:");
            string article = Console.ReadLine();

            Console.WriteLine("Введите количество товара:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            invoice.SetOrderDetails(article, quantity);

            Console.WriteLine("Введите цену за единицу товара:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Рассчитать сумму с НДС? (да/нет):");
            string choice = Console.ReadLine().ToLower();

            double result;

            if (choice == "да")
            {
                result = invoice.GetTotalWithVAT(price);
                Console.WriteLine("\nСумма с НДС: {0:F2} BYN", result);
            }
            else
            {
                result = invoice.GetTotalWithoutVAT(price);
                Console.WriteLine("\nСумма без НДС: {0:F2} BYN", result);
            }

            Console.WriteLine("\nДетали заказа:");
            Console.WriteLine("Счёт: {0}", invoice.Account);
            Console.WriteLine("Покупатель: {0}", invoice.Customer);
            Console.WriteLine("Поставщик: {0}", invoice.Provider);
            Console.WriteLine("Товар: {0}, Кол-во: {1}, Цена за шт: {2:F2}", article, quantity, price);


            Console.ReadKey();
        }
    }
    
}
