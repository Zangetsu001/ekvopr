using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Client
    {
        public string Name;
        public string InsuranceType;
        public decimal InsuranceAmount;

        // Инициализация клиента
        public void Init(string name, string type, decimal amount)
        {
            Name = name;
            InsuranceType = type;
            InsuranceAmount = amount;
        }

        // Получение информации о клиенте
        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}, Вид страховки: {InsuranceType}, Сумма: {InsuranceAmount} руб.");
        }
    }
}
