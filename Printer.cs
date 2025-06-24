using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    enum TextColor
    {
        Black = 0,
        Blue,
        Green,
        Cyan,
        Red,
        Magenta,
        Yellow,
        White
    }
    internal class Printer
    {
        public static void Print(string stroka, int color)
        {
            if (Enum.IsDefined(typeof(TextColor), color))
            {
                Console.ForegroundColor = (ConsoleColor)color;
                Console.WriteLine($"\n{stroka}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Неверный номер цвета.");
            }
        }
    }
}
