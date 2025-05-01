using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ключ (pro / exp), или нажмите Enter для бесплатной версии: ");
            string key = Console.ReadLine();

            DocumentWorker doc;

            if (key == "exp")
            {
                doc = new ExpertDocumentWorker();
                Console.WriteLine("Экспертная версия активирована.");
            }
            else if (key == "pro")
            {
                doc = new ProDocumentWorker();
                Console.WriteLine("Про-версия активирована.");
            }
            else
            {
                doc = new DocumentWorker();
                Console.WriteLine("Бесплатная версия активирована.");
            }

          
            Console.WriteLine("Работа с документом:");
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();


            Console.ReadKey();
        }
    }
}
