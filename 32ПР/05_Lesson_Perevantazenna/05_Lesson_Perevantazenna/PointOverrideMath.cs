using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Lesson_Perevantazenna
{
    public partial class Point
    {
       public static Point operator + (Point p1, Point p2)
        {
            Point p = new Point();
            p.X = p1.X + p2.X;
            p.Y = p1.Y + p2.Y;
            return p;
        }
        public static Point operator +(Point p1, int d)
        {
            Point p = new Point();
            p.X = p1.X + d;
            p.Y = p1.Y + d;
            return p;
        }

        public static int operator +(int d, Point p2)
        {
            d += p2.X;
            d += p2.Y;
            return d;
        }
        public static Point operator ++ (Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
    }
}
