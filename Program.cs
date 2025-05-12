using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите тип документа (xml, txt, doc), или 'exit' для выхода:");
                string type = Console.ReadLine().ToLower();

                if (type == "exit")
                {
                    Console.WriteLine("Выход из программы...");
                    break;
                }

                AbstractHandler handler;

                switch (type)
                {
                    case "xml":
                        handler = new XMLHandler();
                        break;
                    case "txt":
                        handler = new TXTHandler();
                        break;
                    case "doc":
                        handler = new DOCHandler();
                        break;
                    default:
                        Console.WriteLine("Неизвестный формат документа.");
                        continue;
                }

                while (true)
                {
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("1 - Открыть");
                    Console.WriteLine("2 - Создать");
                    Console.WriteLine("3 - Изменить");
                    Console.WriteLine("4 - Сохранить");
                    Console.WriteLine("5 - Изменить тип документа");

                    string choice = Console.ReadLine();

                    if (choice == "5")
                    {
                        break; 
                    }

                    Console.WriteLine(); 

                    switch (choice)
                    {
                        case "1":
                            handler.Open();
                            break;
                        case "2":
                            handler.Create();
                            break;
                        case "3":
                            handler.Change();
                            break;
                        case "4":
                            handler.Save();
                            break;
                        default:
                            Console.WriteLine("Неверный выбор.");
                            break;
                    }
                }


            }
            Console.ReadKey();
        }
    }
}
