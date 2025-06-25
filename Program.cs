using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = {
            new Product { Name="Молоко", Maker="Молоко", Price=20, ShelfLife=5, Quantity=100 },
            new Product { Name="Хлеб", Maker="Хлеб", Price=15, ShelfLife=3, Quantity=50 },
            new Product { Name="Сухарики", Maker="Сухарики", Price=18, ShelfLife=7, Quantity=30 }
        };

            string searchName = "Молоко";
            double maxPrice = 19;
            int minShelfLife = 4;

            Console.WriteLine("а) Название:");
            foreach (var p in products.Where(p => p.Name == searchName))
                Console.WriteLine(p.Maker);

            Console.WriteLine("б) Название и цена:");
            foreach (var p in products.Where(p => p.Name == searchName && p.Price <= maxPrice))
                Console.WriteLine(p.Maker);

            Console.WriteLine("в) Срок хранения > 4:");
            foreach (var p in products.Where(p => p.ShelfLife > minShelfLife))
                Console.WriteLine(p.Maker);
        }
    }
}
