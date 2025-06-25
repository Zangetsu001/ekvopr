using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person> {
            new Person { Name = "Олег", Age = 30 },
            new Person { Name = "Андрей", Age = 25 },
            new Person { Name = "Мария", Age = 22 },
            new Person { Name = "Вика", Age = 27 }
        };

            people.Sort();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, возраст {person.Age}");
            }
        }
    }
}
