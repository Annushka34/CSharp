using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Delegates
{
    class Program
    {
        delegate void MyAction(int x, int y);
        delegate string MyDel_2(int x, int y);
        delegate void MyDel3(string str);
        delegate void MyDel4();
        static void Main(string[] args)
        {
            MyAction action = Show;
            action(5, 12);

            MyDel_2 del = Print;
            string res = del(5, 13);
            string name = "Olga";
            MyDel_2 del2 = delegate (int x, int y){ return name+"   "+(x+y).ToString(); };
            Console.WriteLine(del2(3, 6));

            MyAction del3 = delegate (int x, int y) { Console.WriteLine(x); };
            MyFoo(delegate (int x, int y) { Console.WriteLine(x * y); });

            MyFoo((x, y) => { Console.WriteLine(x * y); });

            MyDel_2 myDel = (x, y) => { return (x * y).ToString(); };
            MyDel_2 myDel_2 = (x, y) => (x * y).ToString();
            MyDel3 myDel3 = s => Console.WriteLine(s);
            MyDel4 del4 = () => Console.WriteLine("Hello");
            del4();
            Foo3(() => Console.WriteLine("Hello world"));

            Foo4(() => Console.WriteLine(name));
            Foo4(() => Console.WriteLine("sdkfhsuhfiushf"));
            Foo4(() => { name = name.ToUpper(); name += " Ivanova"; });
            Console.WriteLine(name);

            //--------------------------------------------------------------------//

        }
        static void Foo4(Action act)
        {
            Console.Write("Foo4: ");
            act();
        }

        static void Foo3(MyDel4 del)
        {
            del();
        }

        static void MyFoo(MyAction act)
        {
            act(10, 20);
        }

        static void Show(int x, int y)
        {
            Console.WriteLine(x+y);
        }

        static string Print(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}
