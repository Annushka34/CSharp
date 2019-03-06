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
        private int size;
        public double [] Arr
        {
            get => arr;
            set => arr = value;
        }
        public MyArrDouble(int s)
        {
            size = s;
            arr = new double[size];
        }

        public override string ToString()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i],4}");
            }
            return "";
        }
    }
}
