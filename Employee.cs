using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Employee
    {
        private string firstName;
        private string lastName;

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void CalculateSalary(string position, int experience, out double salary, out double tax)
        {
            double baseSalary;

   
            if (position.ToLower() == "менеджер")
                baseSalary = 800;
            else if (position.ToLower() == "инженер")
                baseSalary = 1000;
            else if (position.ToLower() == "директор")
                baseSalary = 1500;
            else
                baseSalary = 500;


            double experienceBonus = baseSalary * 0.03 * experience;
            salary = baseSalary + experienceBonus;

            tax = salary * 0.13;
        }

        public string GetFullName()
        {
            return lastName + " " + firstName;
        }
    }
}
