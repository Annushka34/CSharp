using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Lesson
{
    class Lesson1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            //Console.Write("hello hello");
            //Console.Write("hello hello");

            //int ch = Console.Read();
            //Console.WriteLine((char)ch);

            //ConsoleKeyInfo info = Console.ReadKey();
            //if (info.Key == ConsoleKey.Enter)
            //{
            //    Console.WriteLine("You press enter");
            //}
            string str;// = Console.ReadLine();
           // Console.WriteLine(str);
            //Console.WriteLine(str);


          //  Console.BackgroundColor = ConsoleColor.Red;
           // Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Title = "HELLO WORLD";


            //int x = 5;
            //double y = x;
            //int z = (int)y;

            //if (x != 0)
            //{

            //}

            //MyClass m = null;
            //int m1 = 0;
            //if( m != null)
            //{

            //}
            //if (m1 != 0)
            //{

            //}

            //MyStruct? m2 = null;
            //m1 =  m2 == null ? 10 : 20;
            //Foo();

            //int a = 10;
            ////======================================
            //Console.WriteLine("hdfjshdgfh "+str+" ddjhgsjdf");
            //Console.WriteLine($"hello \n  {str}   bbbb  = {a}.");
            //string str1 = @"\ngello\t\n";
            //Console.WriteLine(str1);

            //int x = Int32.Parse(str);
            //Console.WriteLine($"You enter {x}");
            #region TASK1

            str = Console.ReadLine();
            double y;// = double.Parse(str);

            Double.TryParse(str, out y);
            Console.WriteLine($"You enter {y}");

            Double.TryParse(str, out double y1);
            Console.WriteLine(y1);
            #endregion
        }


        static void Foo()
        {
            Console.WriteLine("Foo");
        }


        class MyClass
        {

        }
        struct MyStruct
        {

        }

    }
}
