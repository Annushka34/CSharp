using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    class MetalDoor : IDoor, IOpenable, IClonable
    {
        private string mater = "Metal";
        public int Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsOpen { get; set; } = false;

        public void ChangePrice(int price)
        {
            Price = price;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Close()
        {
            // IsOpen = !IsOpen;
            IsOpen = false;
        }

        public string GetMaterial()
        {
            Console.WriteLine("Metal");
            return mater;
            
        }

        public void Open()
        {
            // IsOpen = !IsOpen;
            IsOpen = true;
        }

        public void SetMaterial(string material)
        {
            mater = material;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Its metal door : " + mater);
            Console.WriteLine( IsOpen ? "Door opened " : "Door closed");
        }

        public void ShowPicture()
        {
            Console.WriteLine("METAL");
        }
    }
}
