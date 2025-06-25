using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    internal class DateClass
    {
        public DateTime Data { get; set; }

        public DateClass() => Data = DateTime.Now;
        public DateClass(int year, int month, int day) => Data = new DateTime(year, month, day);

        public DateTime PrevDay() => Data.AddDays(-1);
        public DateTime NextDay() => Data.AddDays(1);
    }
}
