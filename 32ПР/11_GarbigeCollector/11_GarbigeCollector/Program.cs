using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GarbigeCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amount og genegartions: " + GC.MaxGeneration);

            Human []h = new Human[10000];
            for (int i = 0; i < 10000; i++)
            {
                h[i] = new Human();
            }
            Console.WriteLine("memmory used:" + GC.GetTotalMemory(false));
            Console.WriteLine("Amount colled 0 generation: " + GC.CollectionCount(0));
            Console.WriteLine("Amount colled 1 generation: " + GC.CollectionCount(1));

            Console.WriteLine("Generation of object: " +  GC.GetGeneration(h));
          //  h = null;
            //GC.Collect();
            //Console.WriteLine("Generation of object: " + GC.GetGeneration(h));
            //GC.Collect();
            //Console.WriteLine("Generation of object: " + GC.GetGeneration(h));
            //GC.Collect();
            //Console.WriteLine("Generation of object: " + GC.GetGeneration(h));
        }
    }

    class Human
    {
        public string Name { get; set; }
    }
}
