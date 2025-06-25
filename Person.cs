using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class Person: IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other) => Name.CompareTo(other.Name);
    }
    
    
}
