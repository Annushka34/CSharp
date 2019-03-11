using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes_Inherit
{
    class Amphibia : Animal
    {
        public string LivePlace { get; set; }

        public override void SaySmth()
        {
            Console.WriteLine("i am amphibia");
        }

        public new void Show()
        {
            Console.Write($"live in {LivePlace}   ");
            base.Show();
        }
    }
}
