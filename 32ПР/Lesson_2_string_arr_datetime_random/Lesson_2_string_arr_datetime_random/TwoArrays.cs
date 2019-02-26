using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_string_arr_datetime_random
{
    class TwoArrays
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[5][];
            int[,] arr2 = new int[5, 10];
            int[,] arr3 = { { 1,2,3,4,5 }, { 2,3,4,5,6 } };

            Random r = new Random();

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = r.Next(0, 20);
                }
            }

           // Show(arr2);

            for (int i = 0; i < arr.Count(); i++)
            {
                arr[i] = new int[r.Next(1,10)];
                for (int j = 0; j < arr[i].Count(); j++)
                {
                    arr[i][j] = r.Next(0, 20);
                }
            }

            for (int i = 0; i < arr.Count(); i++)
            {
                for (int j = 0; j < arr[i].Count(); j++)
                {
                    Console.Write($"{arr[i][j], 4}");
                }
                Console.WriteLine();
            }
        }

        static void Show(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j],5}");
                }
                Console.WriteLine();
            }
        }
    }
}
