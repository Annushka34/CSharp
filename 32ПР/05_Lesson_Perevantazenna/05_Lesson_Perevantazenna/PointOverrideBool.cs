using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Lesson_Perevantazenna
{
    public partial class Point
    {
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
        public static bool operator >(Point p1, Point p2)
        {
            return p1.X > p2.X && p1.Y > p2.Y;
        }
        public static bool operator <(Point p1, Point p2)
        {
            return !(p1 > p2);
        }


        public static bool operator >=(Point p1, Point p2)
        {
            return p1.X >= p2.X && p1.Y >= p2.Y;
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return !(p1 >= p2);
        }


        #region OverrideTrueFalse
        public static bool operator true(Point p)
        {
            return p.X != 0 && p.Y != 0;
        }
        public static bool operator false(Point p)
        {
            return !p;
        }
        public static bool operator !(Point p)
        {
            return !(p.X != 0 && p.Y != 0);
        }
        #endregion
    }
}
