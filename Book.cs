using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    struct Book
    {
        public string Title;
        public string Author;
        public int Year;
        public int Pages;

        // Конструктор
        public Book(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }

        // Метод вывода информации
        public void Display()
        {
            Console.WriteLine($"{Author} {Title} {Year}г {Pages}с");
        }
    }
}
