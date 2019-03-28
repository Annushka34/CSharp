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
            Console.WriteLine("---------------------------------");

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

            //var person = new { Name = "AAAA", Age = 12 };
            //var flower1 = new { FlowerName = flowers[0].Name, FlowerPrice = flowers[0].Price, flowers[0].Type };
            //Console.WriteLine(person.Name+person.Age);

            var anonimList = new []
            {
                new {Name = "Ivanov", Salary = 4500},
                new {Name = "Petrov", Salary = 6200},
                new {Name = "Sidorov", Salary = 7800}
            }.ToList();


            anonimList.ForEach(f => Console.WriteLine(f.Name + "  " + f.Salary));

            //----DELEGATES IN SELECT
            var personNames = flowers.Select(delegate (Flower f) { return f.Name; });
            var personNames2 = flowers.Select((f) => f.Name); 
            var personNames3 = flowers.Select(f => f.Name);


            foreach (var item in anonimList)
            {
                Console.WriteLine(item.Name);
            }

            anonimList.Add(new { Name = "Vasiljev", Salary = 9200 });
            anonimList.ForEach((item) => Console.WriteLine(item.Name +"   "+item.Salary));
           // anonimList.ForEach((item) => item.Salary*=10));

            //var anonimList_2 = new object[]
            //{
            //    new {Name = "Ivanov", Salary = 4500},
            //    new {Name = "Petrov", Salary = 6200},
            //    new {Name = "Sidorov", Salary = 7800}
            //}.ToList();
            //foreach (var item in anonimList_2)
            //{
            //    Console.WriteLine(item.Name);
            //}
        }

        static string SelectNames(Flower f, int ind)//  -- Select
        {
            return "["+ind.ToString()+"]"+f.Name;
        }
        static string SelectNames_2(Flower f)//  -- Select
        {
            return f.Name;
        }

        static string ComposeStrings(Flower f)//---Select
        {
            return f.Name + ":" + f.Type +":" + f.Price.ToString();
        }

        static bool FindBlooming(Flower flower)//---FindAll
        {
            return flower.Type == "Квітучі";
        }

        static bool ExpenciveOnly(Flower f)//---FindAll
        {
            return f.Price > 50;
        }

        static int Compare (Flower f1, Flower f2)//---Sort
        {
            return f1.Price == f2.Price? 0 : f1.Price > f2.Price ? 1 : -1;
        }

        static void ShowFlower (Flower f)//---ForEach
        {
            Console.WriteLine(f.Type +"  " + f.Name + "  " + f.Price);
        }

        static void ShowFlower_2(Flower f, char ch)//---ForEach
        {
            Console.WriteLine(f.Type + "  " + f.Name + "  " + f.Price);
        }

        static List<Flower> GetFlowers ()//---Create List
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


        //----------FUNC-------------------
        static string ReturnName()
        {
           Console.WriteLine("Enter name: ");
            string str = Console.ReadLine();
            return str;
        }

        //---------ACTION-------------------
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

        //------------FUNC--------------
        static int CountReturn(int x, int y)
        {
            Random r = new Random();
            SetColor((ConsoleColor)r.Next(1, 10));
            Console.WriteLine("Action 2");
            Console.WriteLine(x + y);
            return x + y;
        }

        //-----HELP for buity------------------
        static void SetColor(ConsoleColor col)
        {
            Console.ForegroundColor = col;
        }
    }
}
