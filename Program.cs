using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя сотрудника:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию сотрудника:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите должность (менеджер, инженер, директор и т.д.):");
            string position = Console.ReadLine();

            Console.WriteLine("Введите стаж (в годах):");
            int experience = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee(firstName, lastName);

            double salary, tax;
            employee.CalculateSalary(position, experience, out salary, out tax);

            Console.WriteLine("\nИнформация о сотруднике:");
            Console.WriteLine("ФИО: " + employee.GetFullName());
            Console.WriteLine("Должность: " + position);
            Console.WriteLine("Оклад: {0:F2} BYN", salary);
            Console.WriteLine("Налоговый сбор (13%): {0:F2} BYN", tax);

            Console.ReadKey();
        }
    }
}
