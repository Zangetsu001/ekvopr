using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        // Метод для изменения структуры
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void Main(string[] args)
        {
            MyClass classObj = new MyClass();
            MyStruct structObj = new MyStruct();

            classObj.change = "не изменено";
            structObj.change = "не изменено";

            ClassTaker(classObj);
            StructTaker(structObj);

            Console.WriteLine("Результат после передачи в метод:");
            Console.WriteLine("Класс: " + classObj.change);    // ОЖИДАЕМО: изменено
            Console.WriteLine("Структура: " + structObj.change); // ОЖИДАЕМО: не изменено

            Console.ReadLine();
        }
    }
}
