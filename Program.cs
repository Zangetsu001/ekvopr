using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TourFirm> firms = new List<TourFirm>
        {
            new TourFirm("Солнышко", 2010, "123456", 50000),
            new TourFirm("Путевка+", 2015, "234567", 70000),
            new TourFirm("МирТур", 2012, "345678", 30000)
        };

            Console.WriteLine("Введите название фирмы для поиска:");
            string name = Console.ReadLine();
            var found = firms.FirstOrDefault(f => f.Name == name);
            if (found != null)
                Console.WriteLine($"ИНН: {found.INN}, Прибыль: {found.Profit}");
            else
                Console.WriteLine("Фирма не найдена.");

            double total = firms.Sum(f => f.Profit);
            Console.WriteLine($"Суммарная прибыль всех фирм: {total}");

            var maxProfitFirm = firms.OrderByDescending(f => f.Profit).First();
            Console.WriteLine($"Максимальная прибыль у фирмы {maxProfitFirm.Name}: {maxProfitFirm.Profit}");

            firms.RemoveAll(f => f.Profit <= 0);
            firms.Add(new TourFirm("НоваяФирма", 2024, "999999", 60000));

            Console.WriteLine("Финальный список фирм:");
            foreach (var f in firms)
                f.ShowInfo();
        }
    }
}
