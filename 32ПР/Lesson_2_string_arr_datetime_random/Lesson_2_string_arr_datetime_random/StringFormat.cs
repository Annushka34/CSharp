//using System;

//namespace Lesson_2_string_arr_datetime_random
//{
//    class StringFormat
//    {
//        static void Main(string[] args)
//        {
//            //string res = Calc(10, 12);
//            //Console.WriteLine( res );
//            //int a = int.Parse(Console.ReadLine());

//            //int.TryParse(Console.ReadLine(), out int x);
//            //Console.WriteLine($"x={x}");


//            int x1;
//            InputVal(out x1);
//            Console.WriteLine($"x1={x1}");

//            int y = 0;
//            InputVal2(ref y);
//            Console.WriteLine($"y={y}");
//            decimal d = 33m;

//            Console.WriteLine(String.Format("format money {0:C}", d));
//            Console.WriteLine("format d {0:d5}", 33);
//            Console.WriteLine("format f {0:f5}", 33);
//            Console.WriteLine("format n {0:n}", 33125648);

//            //---c - money
//            //---d - number, d5 - 5 symbols on number 00033
//            //---f - float(double) f5  - 33,00000
//            //---n - with point/space
//        }

//        static string Calc(int x, int y)
//        {
//            string name = "Alex";
//            //----1---
//            Console.WriteLine("hello {0} hello {1} hello {0}", 10, "Alex");
//            //----2---
//            Console.WriteLine($"hello {x} hello {y} hello {name}");
//            Console.WriteLine("hello "+(x+y));
//            string res = String.Format("sum {0}", x + y);
//            Console.WriteLine(res);
//            return (x + y).ToString();
//        }

//        static void InputVal(out int x)
//        {
//            Console.WriteLine("Enter value: ");
//            x = int.Parse(Console.ReadLine());
//        }

//        static void InputVal2(ref int x)
//        {
//            Console.WriteLine("Enter value: ");
//            x = int.Parse(Console.ReadLine());
//        }
//    }
//}
