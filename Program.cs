using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
           {
                new Book("Программирование на языке высокого уровня", "Павловская И.А.", 2013, 430),
                new Book("Полный справочник по C# 4.0", "Герберт Шилдт", 2010, 900),
                new Book("Понятно о Visual Basic.Net. Самоучитель. В трёх томах", "Лукьян С.Н.", 2005, 800),
                new Book("Практикум по Visual Basic 2007", "Усева О.П.", 2007, 544)
           };

            // Вывод всех книг
            foreach (Book book in books)
            {
                book.Display();
            }

            // Задержка экрана
            Console.ReadLine();
        }
    }
}
