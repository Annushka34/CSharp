using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes_Inherit
{
   class Cats : Mammals
    {
        public Cats():base ()
        {

        }
        public void Mjau()
        {
          //  Console.WriteLine(base._livePlaceAnimal.PlaceName + "  " + base._livePlaceAnimal.Temperature);
            Console.WriteLine("Mjau-mjau");
            base.Voice = "mjau";
        }
        public override void SaySmth()
        {
            Console.WriteLine(Voice);
        }
    }


    //class MyClass : Cats // cant inherit sealed class
    //{

    //}
}
