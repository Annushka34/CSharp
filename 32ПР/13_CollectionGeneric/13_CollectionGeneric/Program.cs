using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_CollectionGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic - коллекции         Необобщенные коллекции
            //List<T>                     ArrayList
            //Dictionary<TKey, TValue>    Hashtable
            //SortedList<TKey, TValue>    SortedList
            //Stack<T>                    Stack
            //Queue<T>                    Queue
            //LinkedList<T>               -

            List<int> list = new List<int>();
            list.Add(10);
            list.AddRange(new int[] { 1, 2, 8, 10, 2 });
            list[0] = 12;
            double avg = list.Average();
            Console.WriteLine("capacity: "+ list.Capacity+ "size: "+ list.Count() );
            int el3 = list.ElementAt(3);
            Console.WriteLine("Element 3 = "+el3);
            var newCol = list.GetRange(2, 3);
            Show(list, "list int");
            Show(newCol, "range from 2 size 3");


            List<string> listStr = new List<string>
            {
                "yyred", "blue", "yeloww","pink"
            };
            listStr.Add("black");

            Console.WriteLine("blue position: "+listStr.IndexOf("blue"));
            Show(listStr, "insert black");

            listStr.Insert(2, "white");
            listStr.InsertRange(1, list.Select(item=>item.ToString()));
            Show(listStr, "list string inserted from list int");

            var max = listStr.Max();
            Console.WriteLine(max);

            // IEnumerable<string> newOrderedList = listStr.OrderBy(x=>x); // create new collection
            //listStr = listStr.OrderBy(x => x).ToList();
            listStr.Sort(); // sorted inner elements/ Dont create new collection
            Show(listStr, "list strings sorted");

            int sum = listStr.Sum(x => (int)x[0]);
            Console.WriteLine("sum  "+sum);


            List<Person> persons = new List<Person>
            {
                new Person{Name = "Vasja", Salary = 2500},
                new Person{Name = "Olga", Salary = 3600},
                new Person{Name = "Inna", Salary = 4200},
                new Person{Name = "Semen", Salary = 7560},
                new Person{Name = "Ivan", Salary = 8900},
                new Person{Name = "Irina", Salary = 9200},
                  new Person{Name = "Vasja", Salary = 2500},
                new Person{Name = "Svitlana", Salary = 3600},
                new Person{Name = "Inna", Salary = 4200},
                new Person{Name = "Semen", Salary = 7560},
                new Person{Name = "Ivan", Salary = 8900},
                new Person{Name = "Oksana", Salary = 9200},
                  new Person{Name = "Vasja", Salary = 2500},
                new Person{Name = "Olga", Salary = 3600},
                new Person{Name = "Sofia", Salary = 4200},
                new Person{Name = "Igor", Salary = 7560},
                new Person{Name = "Ivan", Salary = 8900},
                new Person{Name = "Oleg", Salary = 9200},
                  new Person{Name = "Vasja", Salary = 2500},
                new Person{Name = "Olga", Salary = 3600},
                new Person{Name = "Petro", Salary = 4200},
                new Person{Name = "Semen", Salary = 7560},
                new Person{Name = "Denis", Salary = 8900},
                new Person{Name = "Irina", Salary = 9200}
            };
            Show(persons, "create persons");
            int sumSalary = persons.Sum(item => item.Salary);
            Console.WriteLine("sum salary: "+ sumSalary);

            persons.Sort((obj1, obj2) => { return (obj1 as Person).Name.CompareTo((obj2 as Person).Name); });
            Show(persons, "sorted by name");
            persons = persons.OrderBy(x => x.Salary).ToList();
            Show(persons, "sorted by salary");

            Person p = new Person() { Name = "Vasja", Salary = 2500 };
            persons.Remove(p);
            Show(persons, "try to remove Vasja");

          //  list.Remove(2);
            list.RemoveAll(item => item == 2);
            Show(list, "remove 2");


            persons.Reverse();
            Show(persons, "after reverse");

           // int pageCurrent = 2;
            int pageSize = 5;
            int pageCurrent = int.Parse (Console.ReadLine());
            var curentPage = persons.Skip(pageSize * pageCurrent).Take(pageSize);

            Show(curentPage, pageCurrent.ToString());
        }

        static void Show<T>(IEnumerable<T> ts, string head)
        {
            Console.WriteLine("----------"+head+"-----------------");
            foreach (var item in ts)
            {
                Console.Write(item+"  ");
            }
            Console.WriteLine();
        }

        class Person
        {
            public string Name { get; set; }
            public int Salary { get; set; }
            public override string ToString()
            {
                return Name + " salary: " + Salary +"\n";
            }

            public override bool Equals(object obj)
            {
                return (obj as Person).Name.Equals(this.Name) && (obj as Person).Salary.Equals(this.Salary);
            }
            public override int GetHashCode()
            {
                return (this.Name + this.Salary.ToString()).GetHashCode();// TODO: read about this, how to ovveride GetHashCode if where mode then one field
            }
        }
    }
}
