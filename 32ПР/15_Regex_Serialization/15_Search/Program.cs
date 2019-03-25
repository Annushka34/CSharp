using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = GetSitePage();
            string pattern = @"name""[>]([^<]+)</div>";
            Regex r = new Regex(pattern);

            //if (r.IsMatch(line))
            //{
            //    Console.WriteLine("yes");
            //    Match m = r.Match(line);
            //    Console.WriteLine(m.Value);
            //    while (true)
            //    {
            //        m = m.NextMatch();
            //        if (!m.Success) break;
            //        Console.WriteLine(m.Value + " " + m.Index);
            //    }
            //}
            //else Console.WriteLine("no");

            if (r.IsMatch(line))
            {
                Console.WriteLine("yes");
                MatchCollection mc = r.Matches(line);

                //foreach (var item in mc)
                //{
                //    Console.WriteLine(item);
                //}

                ////---all in () will be in groups
                for (int i = 0; i < mc.Count; i++)
                {
                   // Console.WriteLine(mc[i].Groups[0]);
                    Console.WriteLine(mc[i].Groups[1]);
                    //foreach (var j in mc[i].Groups)
                    //    Console.WriteLine(j);
                }
            }
            else Console.WriteLine("no");
            //Console.WriteLine(line);
        }

        static string GetSitePage()
        {
            string line = "";
            string result = "";
            WebRequest request = WebRequest.Create("http://kino.rv.ua/ru/archive");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        result += line;
                    }
                }
            }
            response.Close();
            Console.WriteLine("Запрос выполнен");
            Console.Read();
            return result;
        }
    }
}
