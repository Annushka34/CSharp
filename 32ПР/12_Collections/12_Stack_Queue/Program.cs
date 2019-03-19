using System;
using System.Collections;

namespace _12_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack ts = new Stack();
            var person = new
            {
                name = "Oleg",
                surname = "Petrov",
                age = 20
            };
            Stack ts1 = new Stack(new object[] { 1, 2, 3, "hello", person });
            Stack ts2 = new Stack(20);
            Stack ts3 = new Stack(new object []{person, person });

            //---show---
            //foreach (var item in ts1)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in ts3)
            //{
            //    Console.WriteLine(item);
            //}

            //ts1[2] - not
            object obj = ts3.Peek();
            // Console.WriteLine(obj);
            object obj1 = ts1.Pop();
            Console.WriteLine(obj1);
            obj1 = ts1.Pop();
            Console.WriteLine(obj1);

            Console.WriteLine();
            foreach (var item in ts1)
            {
                Console.WriteLine(item);
            }

            Queue q = new Queue(2, 4);
            Queue q1 = new Queue(2, 7);

            q.Enqueue(23);
            q1.Enqueue(25);

            Console.WriteLine("size:"+ q.Count);
            Console.WriteLine("size:" + q1.Count);
        }
    }
}
