using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ArrayListSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                Console.WriteLine(item);
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(drives[0].Name);
            var folders = directoryInfo.GetDirectories();


            foreach (var item in folders)
            {
                Console.WriteLine(item);
            }

            MyArrayListSorted myArrayListSorted = new MyArrayListSorted();
            foreach (var item in myArrayListSorted.MyEnum())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            myArrayListSorted.Sort();
            foreach (var item in myArrayListSorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            myArrayListSorted.myArr.Add(new Person { Name = "olga", Surname = "Vasiljeva" });
            myArrayListSorted.Sort();
            foreach (var item in myArrayListSorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }

    class MyArrayListSorted : IEnumerable
    {
        public ArrayList myArr;
        public MyArrayListSorted()
        {
            myArr = new ArrayList(
                new Person[]
                {
                    new Person{Name = "Vasja", Surname = "Ivanov"},
                        new Person{Name = "Ivan", Surname = "Sidorov"},
                      new Person{Name = "Oleg", Surname = "Petrov"}
                }
                );
        }

        public void Sort()
        {
            myArr.Sort();
        }

        public IEnumerator <object> GetEnumerator()
        {
            for (int i = 0; i < myArr.Count; i++)
            {
                if (i%2 == 0)
                yield return myArr[i];
                else
                    yield return "missed";
            }
        }

        public IEnumerable<object> MyEnum()
        {
            for (int i = 0; i < myArr.Count; i++)
            {
                yield return "Person" + i +": "+ myArr[i] ;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return myArr.GetEnumerator();
        }
    }

    class Person : IComparable
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int CompareTo(object obj)
        {
            return this.Surname.CompareTo((obj as Person).Surname);
        }
        public override string ToString()
        {
            return Surname + "  " + Name;
        }
    }
}
