//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _03_Lesson_String
//{
//    class String
//    {
//        static void Main(string[] args)
//        {
//            //string str;
//            //string str1 = "";
//            //string str2 = "hello hello hello hello";
//            //string str3 = str2 + str1;
//            //string str4 = new string('a', 10);
//            ////---string to array
//            //char[] ch = str2.ToCharArray();
//            ////---array to string
//            //string str5 = new string(ch);
//            //string cloneStr = (string)str2.Clone();

//            //Console.WriteLine("Enter str1: ");
//            //str2 = Console.ReadLine();
//            //Console.WriteLine("Enter str2: ");
//            //str3 = Console.ReadLine();


//            //if ( str2.CompareTo(str3) != 0 )
//            //{
//            //    Console.WriteLine("string no equals");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Equals");
//            //}
//            //Console.WriteLine(str2.GetHashCode());
//            //Console.WriteLine(str3.GetHashCode());

//            //str2 += "...";
//            //Console.WriteLine(str2);
//            //Console.WriteLine(str2.GetHashCode());
//            //Console.WriteLine(str3.GetHashCode());

//            ////--------------
//            //if ( str2.Contains("pet") )
//            //{
//            //    Console.WriteLine("this  text available....");
//            //}

//            //str2.CopyTo(0, ch, 0, str2.Length);
//            //bool isTxtFile = str3.EndsWith(".txt");
//            //Console.WriteLine("isTxtFile   "+ isTxtFile);
//           // bool isEqual = str2.Equals(str3);// str2 == str3


//            ////--------------------------------------------------------
//            string str6 = "helloapetmotherfather";

//            char ch1 = str6.First();//--first symbol
//            int a = str6.IndexOf('a');//---return index og symbol
//            Console.WriteLine("a int pos: "+ a);


//            int a1 = str6.IndexOfAny("albc".ToCharArray());//---ant letter from char arr
//            Console.WriteLine("a l b c int pos: " + a1);
//            //Console.WriteLine($"asgdasgda {a1} agdghasgdah {a1} ssfiudius {a} sdfisufisuf");
//            //Console.WriteLine("asgdasgda {0} agdghasgdah {1} ssfiudius {0} sdfisufisuf", a1, a);

//            str6.Insert(2, "...");
//            str6 = str6.ToUpper();
//            Console.WriteLine(str6);

//            str6 = str6.ToLower();//---low register

//            str6 = str6.Remove(2, 3); //-- delete from ind 2 - amount chars - 3
//            str6 = str6.Replace('e', '.');
//           // str6 = str6.Reverse().ToString();

//            var lexems = str6.Split('.');

//            str6 += "............";
//            str6 = "....." + str6;
//            Console.WriteLine("str6:    " + str6);
//            Console.WriteLine(lexems[0]);

//            string strPos3 = str6.Substring(3, 5);
//            Console.WriteLine("strPos3    " + strPos3);

//            str6 = str6.Trim('.');
//            Console.WriteLine("str6:    " + str6);
            
//        }
//    }
//}
