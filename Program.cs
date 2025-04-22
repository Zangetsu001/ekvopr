using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Введите название книги: ");
                string title = Console.ReadLine();

                Console.Write("Введите имя автора: ");
                string author = Console.ReadLine();

                Console.Write("Введите содержание книги: ");
                string content = Console.ReadLine();

                Console.WriteLine("\nИнформация о книге:\n");

                Book myBook = new Book(title, author, content);
                myBook.Show();


                Console.ReadKey();
            
        }
    }
}
