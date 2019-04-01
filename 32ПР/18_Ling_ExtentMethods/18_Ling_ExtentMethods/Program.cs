using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Ling_ExtentMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            str.Show();
            str.PrintCol();

            string str1 = Console.ReadLine();
            str1.PrintCol();


            List<string> list = new List<string>
            {
                "banana","apple","strawberry","kiwi"
            };
            list.Print();

            List<int> list2 = new List<int>
            {
                1,5,7,8,10,3
            };
            Console.WriteLine(list2.Mult());


            Dictionary<int, string> dict = new Dictionary<int, string>
            {
                {10, "Ivanov" },
                {32, "Petrov" },
                {27, "Sidorov" },
                {18, "Ivanov" }
            };
            dict.Print();
        }
    }


    static class MyClass
    {
        static public void Show(this string str)
        {
            Console.WriteLine("***"+str+"***");
        }
        static public void PrintCol(this string str)
        {
            Random r = new Random();
            Console.ForegroundColor = (ConsoleColor)(r.Next(1, 10));
            Console.WriteLine(str);
            Console.ResetColor();
        }

        static public void Print(this List<string> l)
        {
            foreach (var item in l)
            {
                Console.Write($"{item, 15}");
            }
            Console.WriteLine();
        }

        static public int Mult(this List<int> l)
        {
            int m = 1;
            foreach (var item in l)
            {
                m *= item;
            }
            return m;
        }

        static public void Print<T,U>(this Dictionary<T,U> dict)
        {
            foreach (KeyValuePair<T,U> item in dict)
            {
                Console.WriteLine($"{item.Key,10}    {item.Value}");
            }
        }
    }
}
