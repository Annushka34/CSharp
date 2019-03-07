using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
              Animal a1 = new Animal("cat3");
            //  Animal a2 = new Animal("cat");
            //  Animal a3 = new Animal(5);
            //  Animal a4 = new Animal(4, "dog");
            ////  Animal.type = "home animals";
            //  Animal.Counter = 8;
            //  Console.WriteLine(a4);
            //  Console.WriteLine(a3);
            //  Console.WriteLine("-------------------------");
            ////  Animal.ChangeType("wild animals");
            //  Console.WriteLine(a4);
            //  Console.WriteLine(a3);


            Animal.ChangeType("wild animals");
            Console.WriteLine(a1);
            ServiceClass.CheckString(a1.Name);

            //Animal a5 = new Animal { Age = 6, Name = "parrot1" };
            //Animal a6 = new Animal (3) { Name = "parrot2" };
            //Console.WriteLine(a5);
            //Console.WriteLine(a6);

            Family f = new Family (111111)
            {
                Animal = new Animal { Age = 4, Name = "dog" },
                Daddy = new Person("Ole2g"),
                Mam = new Person("Olga")
            };
            Console.WriteLine(f);
            Console.WriteLine(Family.ADRESS_CITY);
            //f.Id = 11321; //- can't do

            //ServiceClass s = new ServiceClass(); - can't do this
        }
    }
}
