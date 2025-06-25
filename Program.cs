using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Zakaz>();
            while (true)
            {
                Console.Write("Введите фамилию (или Q для выхода): ");
                string fam = Console.ReadLine();
                if (fam.ToUpper() == "Q") break;

                Console.Write("Количество мест: ");
                int size = int.Parse(Console.ReadLine());
                Console.Write("Комфорт: ");
                string comfort = Console.ReadLine();

                list.Add(new Zakaz(fam, size, comfort));
            }

            foreach (var z in list) z.Show();
        }
    }
}
