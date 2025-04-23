using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

  
        public readonly DateTime RegistrationDate;

        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RegistrationDate = DateTime.Now;
        }

        public void ShowInfo()
        {
            Console.WriteLine("\nИнформация о пользователе:");
            Console.WriteLine("Логин: " + Login);
            Console.WriteLine("Имя: " + FirstName);
            Console.WriteLine("Фамилия: " + LastName);
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine("Дата заполнения анкеты: " + RegistrationDate.ToString("dd.MM.yyyy HH:mm"));
        }
    }
}
