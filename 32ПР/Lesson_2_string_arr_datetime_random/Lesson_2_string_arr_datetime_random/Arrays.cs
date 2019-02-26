//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson_2_string_arr_datetime_random
//{
//    class Arrays
//    {
//        static void Main(string[] args)
//        {
//            var xx = "mmm";
//            //xx = 2;

//            //---START INITIALIZATION----
//            int[] arr = new int[5];
//            int[] arr1 = new int[] { 1, 2, 3, 5, 12 };
//            int[] arr2 = { 13, 25, 77 };

//            int size = 7;
//            char[] arr3 = new char[size];
//            Array.Resize(ref arr3, size + 1);


//            //----RANDOM----
//            Random r = new Random();

//            //------LOOPS----
//            for (int i = 0; i < arr3.Count(); i++)
//            {
//                arr3[i] = (char)r.Next(25, 100);
//            }
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Array");
//            Console.ResetColor();
       
//            foreach (var item in arr3)
//            {
//                Console.Write($"item = {item, 10}     ");
//            }


//            var arr4 = arr3.Clone();
//            char[] arr5 = new char[size+1];
//            arr3.CopyTo(arr5, 0);

//            Array.IndexOf(arr3, 'a');
//            Array.Sort(arr3);           

//        }

//        void Foo(ref int[] arr)
//        {
//            arr[0] = 100;
//        }
//        }
//}
