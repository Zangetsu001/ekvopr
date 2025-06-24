using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество клиентов: ");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
                Console.Write("Ошибка! Введите положительное целое число: ");

            Client[] clients = new Client[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nКлиент #{i + 1}:");

                Console.Write("Имя: ");
                string name = Console.ReadLine();

                Console.Write("Вид страховки (например, 'автомобиль', 'здоровье', и т.д.): ");
                string type = Console.ReadLine();

                Console.Write("Сумма страховки: ");
                decimal amount;
                while (!decimal.TryParse(Console.ReadLine(), out amount) || amount < 0)
                    Console.Write("Введите корректную сумму: ");

                clients[i] = new Client();
                clients[i].Init(name, type.ToLower(), amount); // приводим тип к нижнему регистру
            }

            Console.WriteLine("\n--- Клиенты с автостраховкой на сумму > 2000 руб. ---");
            foreach (Client client in clients)
            {
                if (client.InsuranceType == "автомобиль" && client.InsuranceAmount > 2000)
                {
                    client.ShowInfo();
                }
            }

            int autoInsuranceCount = 0;
            foreach (Client client in clients)
            {
                if (client.InsuranceType == "автомобиль")
                {
                    autoInsuranceCount++;
                }
            }

            Console.WriteLine($"\nКоличество клиентов с автомобильной страховкой: {autoInsuranceCount}");

            Console.ReadLine();
        }
    }
}
