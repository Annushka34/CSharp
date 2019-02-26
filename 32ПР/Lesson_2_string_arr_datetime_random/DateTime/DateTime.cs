using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMy
{
    class DateTimeMy
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.ToShortDateString());
            //Console.WriteLine(dt.ToLongDateString());
            //Console.WriteLine(dt.ToLongTimeString());
            DateTime dt2 = new DateTime(2018, 12, 20);
            TimeSpan ts = dt - dt2;
            Console.WriteLine(ts.Days);
            dt2.AddDays(2);
        }
    }
}

