using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("1", 12);
            sl.Add("7", 12);
            sl.Add("3", 12);
            sl.Add("4", 12);
            sl["2"] = "cherry";

            foreach (var k in sl.Keys)
            {
                Console.WriteLine(k+"   "+sl[k]+"  ");
            }
            sl.Add("12", 12);
            Console.WriteLine();

            foreach (var k in sl.Keys)
            {
                Console.WriteLine(k + "   " + sl[k] + "  ");
            }
        }
    }
}
