using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    class Family
    {
        public const string ADRESS_CITY = "Rivne"; // - init only here
       // public readonly int Id; // == const but init in constructor
        public static readonly int Id; // == const but init on runtime
        public Person Mam { get; set; }
        public Person Daddy { get; set; }
        public Animal Animal { get; set; }

        static Family()
        {
            Random r = new Random();
            Id = r.Next(10000, 99999);
        }
        public Family()
        {
            Random r = new Random();
         //   Id = r.Next(10000, 99999);
        }

        public Family (int id):this()
        {
         //   Id = id;
        }

        public override string ToString()
        {
            return Id + " " + ADRESS_CITY + " " + Mam.ToString() +" "+ Daddy.ToString()+ " " + Animal.ToString();
        }
    }
}
