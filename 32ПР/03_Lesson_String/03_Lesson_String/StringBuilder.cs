//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _03_Lesson_String
//{
//    class StringBuilder2
//    {
//        static void Main(string[] args)
//        {
//            string str = ".";
//            Stopwatch sWatch = new Stopwatch();
//            //sWatch.Start();
//            //for (int i = 0; i < 200000; i++)
//            //{
//            //    str += ".";
//            //}
//            //sWatch.Stop();
//            //Console.WriteLine(sWatch.ElapsedMilliseconds);

//            StringBuilder strBuild = new StringBuilder();

//            sWatch.Start();
//            for (int i = 0; i < 200000; i++)
//            {
//                strBuild.Append(".");
//            }
//            sWatch.Stop();
//            Console.WriteLine(sWatch.ElapsedMilliseconds);
//            Console.WriteLine(strBuild);
//        }

//        }
//}
