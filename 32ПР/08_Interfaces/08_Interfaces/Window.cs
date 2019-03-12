using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    class Window : IClonable
    {
        public string Material { get; set; }
        public Window(string m)
        {
            Material = m;
        }
        public Window()
        {

        }
        public void Show()
        {
            Console.WriteLine("WINDOW " + Material);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
