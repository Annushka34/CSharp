using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Hashtable ht2 = new Hashtable(10);
            Hashtable ht3 = new Hashtable(ht);

            ht.Add(12, "Ivanov");
            ht.Add("colors", new string[] { "red", "blue", "pink" });

            ht[15] = "Petrov";//----create new
            var colors = ht["colors"];

            //  Console.WriteLine(ht["colors"]);
            Console.WriteLine(ht["sounds"]);

            ICollection keys = ht.Keys;
            ICollection values = ht.Values;

            Console.WriteLine("sounds: " + ht.Contains("sounds"));
            //  ht["sounds"] = new string []{ "gav", "mjav", "brrr" };//----array of strings
            ht["sounds"] = new { dog = "gav", cat = "mjav", bear = "brrr" };
            Console.WriteLine("sounds: " + ht.Contains("sounds"));
            Console.WriteLine(ht["sounds"].GetType().GetMembers()[0].Name);



            foreach (var key in ht.Keys)
            {
                Console.Write("key: "+key+" - ");
                if ( ht[key] is ICollection)
                {
                    foreach (var item in ht[key] as ICollection)
                    {
                        Console.Write(item+"   ");
                    }
                    Console.WriteLine();
                }
                else
                Console.WriteLine(ht[key]);
            }


            object p = new Person();
            //Car c = (Car)p; - danger!!!!!!!!!
            if ( p is Car )//---- ask Person is he Car type?
            {
                Console.WriteLine("p is Car");
            }

            Car c1 = p as Car;//---try to make Car from Person---safty---if can do this c1 will be null (no mistake)
        }
    }

    class Person
    {
        public string Name { get; set; }
    }

    class Car
    {
        public string Name { get; set; }
    }
}
