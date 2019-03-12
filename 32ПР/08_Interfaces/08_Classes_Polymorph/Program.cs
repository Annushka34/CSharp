using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Classes_Polymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.Show();

            Der1 d1 = new Der1();
            d1.Show();

            Der2 d2 = new Der2();
            d2.Show();

            Base b1 = new Der1();
            b1.Show();

            Base b2 = new Der2();
            b2.Show();

            ((Der2)b2).Show();
        }
    }

    class Base
    {
        public virtual void Show()
        {
            Console.WriteLine("Base");
        }
    }

    class Der1 : Base
    {
        public override void Show()
        {
            Console.WriteLine("Der1 ovveride");
        }
    }

    class Der2 : Base
    {
        public new void Show()
        {
            Console.WriteLine("Der2 new");
        }
    }
}
