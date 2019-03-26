using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16_Serialization
{
    [Serializable]
    public class Person
    {
        public string Surname { get; set; }
        private int Age { get; set; }
        public Person()
        {

        }
        public Person(string s, int a)
        {
            Surname = s;
            Age = a;
        }
        public override string ToString()
        {
            return "Person: " + Surname +"   "+ Age;
        }
    }

    [Serializable]
    public class Firm
    {
     //   [NonSerialized]
        public string FirmName;
        public List<Person> persons{ get; set; }
        public Firm()
        {

        }
        public Firm(int amount, string firm)
        {
            FirmName = firm;
            persons = new List<Person>();
            for (int i = 0; i < amount; i++)
            {
                Random r = new Random();
                Thread.Sleep(50);
                persons.Add(new Person("Vasja" + r.Next(0, 10), r.Next(10, 50)));
            }
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(FirmName);
            Console.ResetColor();
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
            return "";
        }
    }
}
