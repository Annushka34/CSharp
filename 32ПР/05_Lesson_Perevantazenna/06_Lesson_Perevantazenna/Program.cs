using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Lesson_Perevantazenna
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArr arrClass = new MyArr();
            Console.WriteLine(arrClass);
            arrClass[2] = 33;
            Console.WriteLine(arrClass);
            arrClass[12] = 102;
            Console.WriteLine(arrClass);
            Console.WriteLine(arrClass[2]);

            Console.WriteLine(arrClass[INDEXES.Second]);

            int x = (int)5.2; // explicit
            double y = x; // implicit

            int s = (int)arrClass;
            Console.WriteLine(s);
            Console.WriteLine("\n---------------------------------------------");
            int[] arr_extr = (int[])arrClass;
            for (int i = 0; i < arr_extr.Length; i++)
            {
                Console.Write(arr_extr[i]+" ");
            }

            MyArr arr2 = (MyArr)5;
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine(arr2);

            MyArrDouble arrDouble = (MyArrDouble)arrClass;
            Console.WriteLine(arrDouble);
        }
    }
}
