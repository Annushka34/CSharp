using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //----CREATE----
            ArrayList myArr = new ArrayList();
            Console.WriteLine("capacity: " + myArr.Capacity);

            MyClass m = new MyClass();
            ArrayList myArr2 = new ArrayList(new object[] { 1, 2, "hello", true, new MyClass(), m });
            ArrayList myArr3 = new ArrayList(25);

            //---METHODS----

            //----add elements---
            myArr.Add(12);
            Console.WriteLine("capacity: " + myArr.Capacity);

            myArr.AddRange(myArr2);
            Console.WriteLine("capacity: " + myArr.Capacity);
            //---insert---
            myArr.Insert(2, "potatoes");
            myArr.InsertRange(4, new int[] { 1, 2, 3 });


            //----show----
            for (int i = 0; i < myArr.Count; i++)
            {
                Console.Write( myArr[i]+"   ");
            }
            Console.WriteLine();
            foreach (var item in myArr)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine();
            Console.WriteLine("real used:"+ myArr.Count+"   capacity: " + myArr.Capacity);
            myArr.TrimToSize();
            Console.WriteLine("real used:" + myArr.Count + "   capacity: " + myArr.Capacity);

            Console.WriteLine("potatoes:" + myArr.Contains("potatoes"));
            Console.WriteLine("1:" + myArr.Contains(1));
            Console.WriteLine("m:" + myArr.Contains(m));

            var newArr = myArr.GetRange(2, 5);
            Show(newArr, "newArr");

            int ind = myArr.IndexOf("potatoes");
            Console.WriteLine("potatoes:" + ind);

            myArr.Remove("potatoes");
            Show(myArr, "remove potatoes");
            Console.WriteLine("potatoes:" + myArr.IndexOf("potatoes"));

            myArr.Reverse();
            myArr.Sort();
        }

        static void Show(ICollection collection, string head)
        {
            Console.WriteLine("------------"+head+"----------------");
            foreach (var item in collection)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine();
        }
    }

    class MyClass
    {
        string str = "my MyClass";
        public override string ToString()
        {
            return str;
        }
    }
}
