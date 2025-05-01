using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n--- МЕНЮ ---");
                Console.WriteLine("1 - Добавить Самолёт");
                Console.WriteLine("2 - Добавить Машину");
                Console.WriteLine("3 - Добавить Корабль");
                Console.WriteLine("4 - Посмотреть все");
                Console.WriteLine("5 - Удалить по номеру");
                Console.WriteLine("6 - Выход");
                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPlane();
                        break;
                    case "2":
                        AddCar();
                        break;
                    case "3":
                        AddShip();
                        break;
                    case "4":
                        ShowAll();
                        break;
                    case "5":
                        DeleteVehicle();
                        break;
                    case "6":
                        Console.WriteLine("Выход из программы...");
                        return;
                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте снова.");
                        break;
                }
            }
        }

        static void AddPlane()
        {
            Console.WriteLine("\n--- Добавление Самолёта ---");
            double x = ReadDouble("X: ");
            double y = ReadDouble("Y: ");
            double price = ReadDouble("Цена: ");
            double speed = ReadDouble("Скорость: ");
            int year = ReadInt("Год: ");
            double height = ReadDouble("Высота: ");
            int passengers = ReadInt("Пассажиры: ");

            vehicles.Add(new Plane(x, y, price, speed, year, height, passengers));
            Console.WriteLine("Самолёт добавлен.");
        }

        static void AddCar()
        {
            Console.WriteLine("\n--- Добавление Машины ---");
            double x = ReadDouble("X: ");
            double y = ReadDouble("Y: ");
            double price = ReadDouble("Цена: ");
            double speed = ReadDouble("Скорость: ");
            int year = ReadInt("Год: ");

            vehicles.Add(new Car(x, y, price, speed, year));
            Console.WriteLine("Машина добавлена.");
        }

        static void AddShip()
        {
            Console.WriteLine("\n--- Добавление Корабля ---");
            double x = ReadDouble("X: ");
            double y = ReadDouble("Y: ");
            double price = ReadDouble("Цена: ");
            double speed = ReadDouble("Скорость: ");
            int year = ReadInt("Год: ");
            int passengers = ReadInt("Пассажиры: ");
            Console.Write("Порт: ");
            string port = Console.ReadLine();

            vehicles.Add(new Ship(x, y, price, speed, year, passengers, port));
            Console.WriteLine("Корабль добавлен.");
        }

        static void ShowAll()
        {
            Console.WriteLine("\n--- Все транспортные средства ---");
            if (vehicles.Count == 0)
            {
                Console.WriteLine("Список пуст.");
                return;
            }

            for (int i = 0; i < vehicles.Count; i++)
            {
                vehicles[i].ShowInfo(i);
            }
        }

        static void DeleteVehicle()
        {
            ShowAll();
            if (vehicles.Count == 0) return;

            int index = ReadInt("\nВведите номер для удаления: ");
            if (index >= 0 && index < vehicles.Count)
            {
                vehicles.RemoveAt(index);
                Console.WriteLine("Удалено.");
            }
            else
            {
                Console.WriteLine("Неверный номер.");
            }
        }

        static double ReadDouble(string msg)
        {
            Console.Write(msg);
            return Convert.ToDouble(Console.ReadLine());
        }

        static int ReadInt(string msg)
        {
            Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
