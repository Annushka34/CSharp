using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15_Regex_Serializ
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern2 = @"\(hello\)";// search (hello)
            string pattern3 = @"(5)";// search hello            
            string pattern4 = @"^ok$";//search ok in the begin and end of the line
            string pattern5 = @"^(ok)+$";//search ok 1 or more time

            string pattern6 = @"\d";//search any digit
            string pattern7 = @"^\d\d\d$";//search any digin 3 times

            string pattern8 = @"^A.+\d.+A$";// line begin on A has one or more digit and end on A

            string pattern9 = @"^.+hello(.+)bye.+$";// line has any symbols, hello, any symbols, bye, any symbols

            string pattern10 = @"\d{2}-\d{2}-\d{2}";
            string pattern11 = @"\([1-9]{3}\)[1-9]{2,4}";// \s - space

            string pattern = @"^[a-zA-Z][a-zA-Z0-9-_]+@[a-z]+\.[a-zA-Z]{2,3}";

            Regex r = new Regex(pattern);


            //string myStr = Console.ReadLine();
            //if (r.IsMatch(myStr))
            //{
            //    Console.WriteLine("yes");
            //    Match m = r.Match(myStr);
            //    Console.WriteLine(m.Value);
            //    while (true)
            //    {
            //        m = m.NextMatch();
            //        if (!m.Success) break;
            //        Console.WriteLine(m.Value + " " + m.Index);
            //    }
            //}
            //else Console.WriteLine("no");

            string myStr = Console.ReadLine();
            if (r.IsMatch(myStr))
            {
                Console.WriteLine("yes");
                MatchCollection mc =  r.Matches(myStr);

                //foreach (var item in mc)
                //{
                //    Console.WriteLine(item);
                //}

                //---all in () will be in groups
                for (int i = 0; i < mc.Count; i++)
                {
                    foreach (var j in mc[i].Groups)
                        Console.WriteLine(j);
                }
            }
            else Console.WriteLine("no");

        }
    }
}
