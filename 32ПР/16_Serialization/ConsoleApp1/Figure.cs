using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Figure
    {
        public int Color { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public Figure()
        {

        }
        public Figure(int c, int w, int l)
        {

            Color = c;
            Width = w;
            Length = l;
        }
        public override string ToString()
        {
            return "Class Figure : " + "Length = " + Length + " Width = " + Width + " Color " + Color;
        }
    }
}
