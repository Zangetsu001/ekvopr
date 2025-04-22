using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address myAddress = new Address();

            myAddress.Index = "5373223";
            myAddress.Country = "ПМР";
            myAddress.City = "Тирасполь";
            myAddress.Street = "Магистральная";
            myAddress.House = "12";
            myAddress.Apartment = "45";

            Console.WriteLine("Почтовый адрес:");
            Console.WriteLine($"Индекс: {myAddress.Index}");
            Console.WriteLine($"Страна: {myAddress.Country}");
            Console.WriteLine($"Город: {myAddress.City}");
            Console.WriteLine($"Улица: {myAddress.Street}");
            Console.WriteLine($"Дом: {myAddress.House}");
            Console.WriteLine($"Квартира: {myAddress.Apartment}");


            Console.ReadKey();
        }
    }
}
