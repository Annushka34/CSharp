using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17_Delegates_2
{
    class Program
    {
        delegate void Del(string str);
        static void Main(string[] args)
        {
            Del d = Foo1;
            d += Foo2;
            d += Foo3;
            d += Foo3;
            d += Foo3;
            d += Foo4;
            d += (str) => { Console.WriteLine(str + "I do nothing"); };
           // d("My name is Ivan");
        //    Thread.Sleep(2000);
         //   Console.WriteLine("----------------------------------------");
            d -= Foo2;
            d -= Foo3;
            d -= Foo1;

            d?.Invoke("Ivan");
            //  d("My name is Ivan");

            foreach (Del item in d.GetInvocationList())
            {
              //  Console.WriteLine(item.Method);
                item?.Invoke("Olga");
            }
        }

        static void Foo1(string s)            
        {
            SetColor(ConsoleColor.Red);
            Console.WriteLine("I go on the work");
            Console.WriteLine(s);
        }
        static void Foo2(string s)
        {
            SetColor(ConsoleColor.Gray);
            Console.WriteLine("I'm eating");
            Console.WriteLine(s);
        }
        static void Foo3(string s)
        {
            SetColor(ConsoleColor.Green);
            Console.WriteLine("I'm relaxing now");
            Console.WriteLine(s);
        }
        static void Foo4(string s)
        {
            SetColor(ConsoleColor.Magenta);
            Console.WriteLine("I 'm sleaping now");
            Console.WriteLine(s);
        }


        //-----HELP for buity------------------
        static void SetColor(ConsoleColor col)
        {
            Console.ForegroundColor = col;
        }
    }
}
