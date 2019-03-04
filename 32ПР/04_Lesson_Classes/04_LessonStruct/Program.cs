using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LessonStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //  checked
            //{
            //    short a =  short.Parse(Console.ReadLine());
            //    //a += 1000;
            //    //Console.WriteLine(a);

            //    short a1 = short.Parse(Console.ReadLine());
            //    a =  checked((byte)(a + a1));
            //    Console.WriteLine(a);
            //}

            //checked
            //{
            //    byte b = 255;
            //    b += 2;
            //    Console.WriteLine(b);
            //}

            //Foo(20, 12, 25, 23, 2.3, "hgfhgfhg");

            //Foo2(2,3,5);
            //Foo2(113,2,3,5,6); 


            HumanStruct hStr = new HumanStruct();
            hStr.Init();
            // HumanStruct hStr2;//---no default values for params
            HumanStruct hStr2 = new HumanStruct();
            hStr2.Init();
            Console.WriteLine($"name { hStr.name } age { hStr.age }");
            //Console.WriteLine($"name { hStr2.name } age { hStr2.age }");

            Change(ref hStr);
            Console.WriteLine($"name { hStr.name } age { hStr.age }");

            Console.WriteLine("-------------------------------------");
            HumanClass hc = new HumanClass();
            hc.name = "Vasja";
            Console.WriteLine($"name { hc.name } age { hc.age }");
            ChangeClass( ref hc);
            Console.WriteLine($"name { hc.name } age { hc.age }");

            Console.WriteLine("-------------------------------------");

            hStr2 = hStr; //---its two different objects
            hStr.age = 13;
            hStr.humanClass.age = 100;
            Console.WriteLine($"name { hStr.name } age { hStr.age }  humanClassAge {hStr.humanClass.age} hashCode {hStr.GetHashCode()}");
            Console.WriteLine($"name { hStr2.name } age { hStr2.age } humanClassAge {hStr.humanClass.age}   hashCode {hStr2.GetHashCode()}");

            Console.WriteLine("-------------------------------------");

            HumanClass hc2 = hc;//----its only one object and two references
            hc.age = 13;
            Console.WriteLine($"name { hc.name } age { hc.age }   hashCode {hc.GetHashCode()}");
            Console.WriteLine($"name { hc2.name } age { hc2.age }    hashCode {hc2.GetHashCode()}");
        }

        static void Change ( ref HumanStruct hs)
        {
            hs.age = 80;
        }
        static void ChangeClass( ref HumanClass hs)
        {
            hs.age = 80;
            hs = new HumanClass();
            hs.age = 25;
        }

        struct HumanStruct
        {
           public string name;
           public int age;
           public HumanClass humanClass;

            //public HumanStruct()//---can't do this for struct
            //{
            //    this.name = "khkj";
            //    this.age = 10;
            //}
            public void Init()
            {
                humanClass = new HumanClass();
                humanClass.age = 99;
            }
            public HumanStruct(string name)//---must be initilazed all params
            {
                this.name = name;
                this.age = 10;
                humanClass = null;
            }
        }


        class HumanClass
        {
           public string name;
           public int age;
        }


        static void Foo( params object [] val )
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }


        static void Foo2 (int a1, int b1, double v3,  int b = 32, int c = 33 )
        {
            Console.WriteLine(a1);
        }
    }
}
