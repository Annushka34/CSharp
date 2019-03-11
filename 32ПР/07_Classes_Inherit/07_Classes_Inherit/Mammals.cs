using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes_Inherit
{
   abstract class Mammals: Animal
    {
        public string Voice { get; set; }
        protected LivePlaceAnimal _livePlaceAnimal { get; set; } = new LivePlaceAnimal();

        public Mammals(): this ("diff colors")
        {
          //  Console.WriteLine("default mammals");
        }
        public Mammals(string color): base(null, color)
        {
            _livePlaceAnimal.PlaceName = "Суша і деякі моря і океани";
            _livePlaceAnimal.Temperature = 10;
        }
  

        public sealed override void Show()
        {
            Console.WriteLine("show from mammals");
            base.Show();
        }

      
    }
}
