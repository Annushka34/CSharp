using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Lesson_Perevantazenna
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.X = 101;
            p.Y = 125;
            Console.WriteLine(p);
            Point p1 = new Point();
            p1.X = 100;
            p1.Y = 124;
            Console.WriteLine(p1);
            //p1 = p;
            Console.WriteLine("p1 equals p  "+p1.Equals(p));
            Console.WriteLine("p1 == p  " + (p1 == p));

            Console.WriteLine("Hash Code p = "+p.GetHashCode());
            Console.WriteLine("Hash Code p1 = " + p1.GetHashCode());

            Console.WriteLine("p > p1  " + (p > p1));
        }
    }
}
