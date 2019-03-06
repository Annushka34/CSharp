using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Lesson_Perevantazenna
{
    enum INDEXES { First, Second, Fierd};
    class MyArr
    {
        private int[] arr;
        private int size = 5;
        public MyArr()
        {
            arr = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = r.Next(0, 10);
            }
        }
        public override string ToString()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i],4}");
            }
            return "";
        }

        public int this[int ind]
        {
            get
            {
                if (ind >= 0 && ind < size)
                return arr[ind];
                return 0;
            }
            set
            {
                if (ind >= 0 && ind < size)
                    arr[ind] = value;
                else
                {
                    size++;
                    Array.Resize(ref this.arr, size);
                    arr[size - 1] = value;
                }
            }
        }
        public int this[INDEXES ind]
        {
            get
            {
                if ((int)ind >= 0 && (int)ind < size)
                    return arr[(int)ind];
                return 0;
            }
            set
            {
                if ((int)ind >= 0 && (int)ind < size)
                    arr[(int)ind] = value;
                else
                {
                    size++;
                    Array.Resize(ref this.arr, size);
                    arr[size - 1] = value;
                }
            }
        }

        public static explicit operator int ( MyArr myArr )
        {
           int sum =  myArr.arr.Sum(x => x);
           return sum;
        }

        public static explicit operator int[] (MyArr myArr)
        {
            return myArr.arr;
        }

        public static explicit operator MyArr (int val)
        {
            MyArr myArr = new MyArr();
            for (int i = 0; i < myArr.size; i++)
            {
                myArr.arr[i] = val;
            }
            return myArr;
        }

        public static explicit operator MyArrDouble (MyArr myArr)
        {
            MyArrDouble myArrDouble = new MyArrDouble(myArr.size);
            for (int i = 0; i < myArr.size; i++)
            {
                myArrDouble.Arr[i] = myArr.arr[i];
            }
            return myArrDouble;
        }
    }
}
