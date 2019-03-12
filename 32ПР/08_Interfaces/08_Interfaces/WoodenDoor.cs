using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    class WoodenDoor : IDoor, IClonable
    {
        private string material = "Wood";
        public int Price { get; set; }

        public void ChangePrice(int price)
        {
            this.Price = price;
        }

        public object Clone()
        {
            //---if this class contain reference types---
            //---i must do this----
            WoodenDoor w = new WoodenDoor();
            w.material = this.material;
            w.Price = this.Price;
            return w;
        }

        public string GetMaterial()
        {
            return material;
        }

        public void SetMaterial(string material)
        {
            this.material = material;
        }

        public void ShowInfo()
        {
            Console.WriteLine("It is door from : " + material);
        }
        public void ShowPicture()
        {
            Console.WriteLine("WOOD");
        }
    }
}
