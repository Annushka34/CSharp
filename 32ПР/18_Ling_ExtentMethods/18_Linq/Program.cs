using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------SELECT--------------------------
            List<string> myListString = new List<string>
            {
                "banana", "apple", "strawberry", "kiwi", "apple", "lemon", "orange"
            };
            var col1 = from item in myListString select item;
            var col2 = myListString.Select(item => item).ToList();
            foreach (var item in col2)
            {
                Console.Write(item+"   ");
            }

            myListString[0] = "snow";
            Console.WriteLine();
            foreach (var item in col2)
            {
                Console.Write(item + "   ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //------------INPUT--------------
            List<FruitsVeget> fruits = new List<FruitsVeget>
            {
                new FruitsVeget{name = "banana", price = 38, type = "Fruit", amount = 3},
                new FruitsVeget{name = "apple", price = 11, type = "Fruit", amount = 5},
                new FruitsVeget{name = "astrawberry", price = 56, type = "Fruit", amount = 8},
                new FruitsVeget{name = "akiwi", price = 42, type = "Fruit", amount = 7},
                new FruitsVeget{name = "lemon", price = 40, type = "Fruit", amount = 1},
                new FruitsVeget{name = "orange", price = 39, type = "Fruit", amount = 0},
                new FruitsVeget{name = "potatoes", price = 9, type = "Vegetable", amount = 0},
                new FruitsVeget{name = "tomato", price = 57, type = "Vegetable", amount = 3}
            };

            foreach (var item in fruits)
            {
                Console.WriteLine($"{item.price} {item.name} {item.type}");
            }

            //------------OUTPUT--------------
            IEnumerable<string> namesFruitsVeg = fruits.Select(item => item.name);
            Console.WriteLine();
            foreach (var item in namesFruitsVeg)
            {
                Console.WriteLine($"{item}");//---item->name
            }
            Console.WriteLine();
            fruits[0].name = "crocodile";
            foreach (var item in namesFruitsVeg)
            {
                Console.WriteLine($"{item}");//---item->name
            }

            IEnumerable<double> prices = fruits.Select(x => (double)x.price * 100);           
            unsafe
            {
                //int a = 10;
                //int* la = &a;
                //Console.WriteLine(*la);
            }

            //-------------------WHERE-------------------------
            PrintHead("WHERE");
            IEnumerable<FruitsVeget> expenc = fruits.Where(x => x.price > 50);
            foreach (var item in expenc)
            {
                Console.WriteLine($"{item.price} {item.name} {item.type}");
            }
            fruits[0].price = 99;
            PrintHead("change price first elem on 99");
            foreach (var item in expenc)
            {
                Console.WriteLine($"{item.price} {item.name} {item.type}");
            }


            IEnumerable<FruitsVeget> res2 = fruits.Where(x => x.price < 30 && x.type == "Fruit");
            PrintHead("only fruits less then 30");
            foreach (var item in res2)
            {
                Console.WriteLine($"{item.price} {item.name} {item.type}");
            }


            //----------------WHERE + SELECT--------------------
            PrintHead("WHERE + SELECT");
            IEnumerable<string> res3 = fruits.Where(x => x.type == "Fruit").Select(x => x.name);
            foreach (var item in res3)
            {
                Console.Write(item+"   ");
            }
            PrintHead("select 3th letter from fruits where name start with a");
            IEnumerable<char> res4 = fruits.Where(x => x.type == "Fruit" && x.name.StartsWith("a")).Select(x => x.name[3]);
            foreach (var item in res4)
            {
                Console.WriteLine(item);
            }

            //----------------SELECT NEW OBJECT--------------
            PrintHead("SELECT NEW OBJECT");
            Random r = new Random();
            var res5 = fruits.Select(x => new { color = r.Next(1,10), fruitName = x.name, fruitPrice = x.price*100 });
            foreach (var item in res5)
            {
                Console.WriteLine($"{item.color} {item.fruitName} {item.fruitPrice}");
            }

            //----------------AGGREGATE-----------------------
            Console.WriteLine("AVG price:"+   fruits.Average(x => x.price));
            Console.WriteLine("MAX price:" + fruits.Max(x => x.price));
            Console.WriteLine("MIN price:" + fruits.Min(x => x.price));
            Console.WriteLine("COST fruits:" + fruits.Where(x=>x.type=="Fruit").Sum(x => x.price * x.amount));
            Console.WriteLine("COST veg:" + fruits.Where(x => x.type == "Vegetable").Sum(x => x.price * x.amount));

            Console.WriteLine("Amount veg:" + fruits.Where(x => x.type == "Vegetable").Count());

            PrintHead("TYPES");
            var types = fruits.Select(x => x.type).Distinct();//----without repeat
            foreach (var item in types)
            {
                Console.WriteLine(item);
            }

            FruitsVeget orange =  fruits.FirstOrDefault(x => x.name == "orange");
            Console.WriteLine("orange "+ orange?.name +" "+ orange?.amount + orange?.price +orange?.type);

            fruits = fruits.OrderBy(x => x.amount).ToList();
            var page2 = fruits.Skip(3).Take(4);
            var pricesHist = fruits.SelectMany(x => x.historyPrices).ToList();

            //------------------------GROUPING--------------------
            PrintHead("GROUPING");
            var groups = fruits.GroupBy(x => x.name);
            var costs = groups.Select(x => new { type = x.Key,  cost = x.Sum(p => p.amount * p.price) });
            foreach (var item in costs)
            {
                Console.WriteLine(item.type+" "+item.cost);
            }

            foreach (IGrouping<string, FruitsVeget> group in groups)
            {
                Console.ForegroundColor = (ConsoleColor)(r.Next(1, 10));
                Console.WriteLine(group.Key);
                Console.ResetColor();
                foreach (var item in group)
                {
                     Console.WriteLine($"name: {item.name} amount: {item.amount} price: {item.price}");
                }
            }
        }
        static void PrintHead(string str)
        {
            Random r = new Random();
            Console.ForegroundColor = (ConsoleColor)(r.Next(1, 10));
            Console.WriteLine("---------------------"+str+"-----------------");
            Console.ResetColor();
        }
    }

    class FruitsVeget
    {
        public string name { get; set; }
        public int price { get; set; }
        public string type { get; set; }
        public int amount { get; set; }
        public List<int> historyPrices { get; set; }
        public FruitsVeget()
        {
            historyPrices = new List<int> { 10, 20, 50 };
        }
    }
}
