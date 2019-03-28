using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Func_Predicate_Compar
{
    class Program
    {
        static void Main(string[] args)
        {
            //----DONT RETURN ANYTHING - ACTION
            Action action;
            action = Show;
            action();

            Action<int, int> action2 = Count;
            action2(10, 13);

            Action<string> action3 = Show;
            action3("Hello");

            //-----return smth and has arguments - FUNC
            Func<int, int, int> func = CountReturn;
            int res = func(5, 7);
            Console.WriteLine("Res func = " + res);

            Func<string> func2 = ReturnName;
            Console.WriteLine(func2());

            //----Compare
            //----Predicate
            SetColor(ConsoleColor.Green);
            List<Flower> flowers = GetFlowers();
            flowers.ForEach(ShowFlower);

            SetColor(ConsoleColor.Cyan);
            flowers.Sort(Compare);
            flowers.ForEach(ShowFlower);

            var blooming = flowers.FindAll(FindBlooming);
            SetColor(ConsoleColor.Gray);
            blooming.ForEach(ShowFlower);

            var expencive = flowers.FindAll(ExpenciveOnly);
            SetColor(ConsoleColor.Red);
            expencive.ForEach(ShowFlower);

            var names = flowers.Select(SelectNames).ToList();
            names.ForEach((name) => { SetColor(ConsoleColor.White); Console.WriteLine(name); });

            SetColor(ConsoleColor.Red);
            var stringFlowers = flowers.Select(ComposeStrings).ToList();
            foreach (var item in stringFlowers)
            {
                Console.WriteLine(item);
            }
        }

        static string SelectNames(Flower f)
        {
            return f.Name;
        }

        static string ComposeStrings(Flower f)
        {
            return f.Name + ":" + f.Type +":" + f.Price.ToString();
        }

        static bool FindBlooming(Flower flower)
        {
            return flower.Type == "Квітучі";
        }

        static bool ExpenciveOnly(Flower f)
        {
            return f.Price > 50;
        }

        static int Compare (Flower f1, Flower f2)
        {
            return f1.Price == f2.Price? 0 : f1.Price > f2.Price ? 1 : -1;
        }

        static void ShowFlower (Flower f)
        {
            Console.WriteLine(f.Type +"  " + f.Name + "  " + f.Price);
        }

        static List<Flower> GetFlowers ()
        {
            List<Flower> flowers = new List<Flower>
            {
                new Flower{ Name = "Бегонія", Price = 13, Type="Декоративно листова" },
                new Flower{ Name = "Азалія", Price = 100, Type="Квітучі" },
                new Flower{ Name = "Фуксія", Price = 127, Type="Квітучі" },
                new Flower{ Name = "Фіалка", Price = 45, Type="Квітучі" },
                new Flower{ Name = "Драцена", Price = 8, Type="Декоративно листова" }
            };
            return flowers;
        }

        static string ReturnName()
        {
           Console.WriteLine("Enter name: ");
            string str = Console.ReadLine();
            return str;
        }

        static void Show()
        {
            SetColor(ConsoleColor.Red);
            Console.WriteLine("Action 1");
        }
        static void Show(string str)
        {
            SetColor(ConsoleColor.Red);
            Console.WriteLine("Action 3 "+str);
        }

        static void Count(int x, int y)
        {
            Random r = new Random();
            SetColor((ConsoleColor)r.Next(1,10));
            Console.WriteLine("Action 2");
            Console.WriteLine(x+y);
        }

        static int CountReturn(int x, int y)
        {
            Random r = new Random();
            SetColor((ConsoleColor)r.Next(1, 10));
            Console.WriteLine("Action 2");
            Console.WriteLine(x + y);
            return x + y;
        }

        static void SetColor(ConsoleColor col)
        {
            Console.ForegroundColor = col;
        }
    }
}
