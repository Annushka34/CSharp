using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    static class ServiceClass
    {
        public static void Head(string smth)
        {
            WriteLine( $"-----------{smth}-----------------");
        }

        public static void Bottom()
        {
            WriteLine($"phone by 444-56-123");
        }

        public static void MenuShow()
        {
            WriteLine($"1. Add \n2. Remove \n3.Close ");
        }

        public static int Sum (int a, int b)
        {
            return a + b;
        }

        public static bool CheckString(string str)
        {
            int ind =  str.IndexOfAny("1234567890".ToCharArray());
            ForegroundColor = ConsoleColor.Red;
            if (ind >= 0) WriteLine("contains digits!!!! No valid!!!!");
            ResetColor();
            return ind < 0;
        }
    }
}
