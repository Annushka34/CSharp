using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    class Animal
    {
        private int age;
        private string name;
        private static int counter = 0;
        public static string type;
        public static  int Counter { get => counter; set=> counter = value; }
        public int Age { get => age; set => age = value > 0 && value < 100 ? value : 0; }
        public string Name { get; set; }

        //------------STATIC CONSTRUCTOR--------------
        static Animal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("init type");
            type = "default";
            Console.ResetColor();
        }

        public Animal(): this(0, "default")
        {
          
        }
        public Animal(int age): this(age, "default")
        {
            Console.WriteLine("CRETE ANIMAL 2");
        }
        public Animal(int a, string name)
        {
           Console.WriteLine("CRETE ANIMAL 3");
           Age = a;
           Name = name;
           counter++;
            //Console.WriteLine("init type");
            //type = "default";
        }
        public Animal(string name): this(0, name)
        {
            Console.WriteLine("CRETE ANIMAL 4");
        }

        public override string ToString()
        {
            return String.Format("Animal: {0} {1}  number {2}  type {3}", Age, Name, counter, type);
        }


        public static void ChangeType(string newType)
        {
           // this. - no this in static method
            type = newType;
            // Age - can't have access to no static members
        }
    }
}
