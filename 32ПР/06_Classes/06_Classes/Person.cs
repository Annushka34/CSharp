using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            ServiceClass.CheckString(name);
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
