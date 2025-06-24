using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите должность сотрудника:");
            string inputPost = Console.ReadLine();

            Console.WriteLine("Введите количество отработанных часов:");
            string hoursStr = Console.ReadLine();
            int hours;

            if (!int.TryParse(hoursStr, out hours))
            {
                Console.WriteLine("Ошибка: введите корректное количество часов.");
                return;
            }

            Post workerPost;
            bool validPost = false;

            // Перебор вручную для совместимости с C# 7.3
            foreach (Post post in Enum.GetValues(typeof(Post)))
            {
                if (post.ToString().Equals(inputPost, StringComparison.OrdinalIgnoreCase))
                {
                    workerPost = post;
                    validPost = true;

                    Accauntant accountant = new Accauntant();
                    bool hasBonus = accountant.AskForBonus(workerPost, hours);

                    if (hasBonus)
                        Console.WriteLine("Сотруднику положена премия.");
                    else
                        Console.WriteLine("Сотруднику не положена премия.");

                    break;
                }
            }

            if (!validPost)
            {
                Console.WriteLine("Ошибка: такой должности не существует.");
            }

            Console.ReadLine();
        }
    }
   
}
