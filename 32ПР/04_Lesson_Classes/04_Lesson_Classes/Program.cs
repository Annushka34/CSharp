using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Lesson_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Doll d = new Doll();
            Car c = new Car();
            c.Show();
            Console.WriteLine(c.GetType().Name);
            Console.WriteLine(c.Price);
            Console.WriteLine(c.GetPrice());

            c.Price = 255;
            Console.WriteLine(c.Price);


            c.Doll = new Doll();
            // Doll d = c.Doll;

            c.Pswd = "1234567";
            /// Console.WriteLine(c.Pswd); - get private!!!!!!!!!!!
            c.Pswd = "123";
            c.Pswd = "1234567";
            c.Pswd = "147258";
        }
    }

    class Doll
    {
        public Doll()
        {
            Console.WriteLine("Doll created");
        }
      
    }
}
