using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes_Inherit
{
    class Dogs : Mammals
    {
        public override void SaySmth()
        {
            Console.WriteLine("I am dog");
        }

        public void Gav()
        {
            Console.WriteLine("gav-gav");
        }
    }
}
