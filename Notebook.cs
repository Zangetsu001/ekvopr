using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    struct Notebook
    {
        public string Model;
        public string Manufacturer;
        public double Price;

        // Конструктор
        public Notebook(string model, string manufacturer, double price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }

        // Метод для вывода
        public void PrintInfo()
        {
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Производитель: {Manufacturer}");
            Console.WriteLine($"Цена: {Price} руб.");
        }
    }
}
