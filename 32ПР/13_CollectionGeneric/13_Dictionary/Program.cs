using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> dict = new Dictionary<string, Person>()
            {
                {"person 1", new Person{Name = "Vasja", Salary = 5600} },
                {"person 2", new Person{Name = "Semen", Salary = 6500} }
            };

            Show(dict, "CREATE NEW");

            dict.Add("person 3", new Person { Name = "Petro", Salary = 7890 });
            if (dict.ContainsKey("person 4"))
            {
                Console.WriteLine(dict["person 4"]);//---NOT EXISTING
            }
            try
            {
                Console.WriteLine(dict["person 4"]);//---NOT EXISTING
            }
            catch { }
            dict.TryGetValue("person 4", out var pers4);//---NOT EXISTING
            //    dict.TryGetValue("person 3", out Person pers3);
            Console.WriteLine(pers4);

            Console.WriteLine("ONLY VALUES");
            var vals = dict.Values;
            foreach (var item in vals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("ONLY KEYS");
            var keys = dict.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            // KeyValuePair<string, Person> keysVals = new KeyValuePair<string, Person>("person 4", new Person { Name = "Irina", Salary = 9870 }); - SEPARETE
            dict["person 5"] = new Person { Name = "aaaa", Salary = 5465 };
            dict["person 5"] = new Person { Name = "bbbb", Salary = 5465 };//---rewrite

            Show(dict, "SHOW LINE 52");

            var max = dict.Max(x=>x.Key);
            Console.WriteLine("max" + max);

            dict = dict.OrderBy(x => x.Value.Salary).ToDictionary(x=>x.Key, x=>x.Value);
            Show(dict, "ORDER BY");

            dict.Remove("person 5");
            dict.Remove("person 6");//---not throw rexeption
            Show(dict, "AFTER REMOVE");            
        }
        static void Show<T, U>(Dictionary<T, U> dict, string head)
        {
            Console.WriteLine("----------" + head + "-----------------");
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            Console.WriteLine();
        }

        static void Show(Dictionary<string, Person> dict, string head)
        {
            Console.WriteLine("----------" + head + "-----------------");
            foreach (KeyValuePair<string, Person> item in dict)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            Console.WriteLine();
        }

        class Person
        {
            public string Name { get; set; }
            public int Salary { get; set; }
            public override string ToString()
            {
                return Name + " salary: " + Salary + "\n";
            }
        }
    }
}
