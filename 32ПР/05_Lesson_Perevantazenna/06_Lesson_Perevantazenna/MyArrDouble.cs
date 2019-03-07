using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Lesson_Perevantazenna
{
    class MyArrDouble
    {
        private double[] arr;
        public int Size { get; set; }
        public double [] Arr
        {
            get => arr;
            set => arr = value;
        }
        public MyArrDouble(int s)
        {
            Size = s;
            arr = new double[Size];
        }

        public override string ToString()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write($"{arr[i],4}");
            }
            return "";
        }
    }
}
