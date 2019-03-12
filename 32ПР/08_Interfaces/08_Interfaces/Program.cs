using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // IDoor d = new IDoor(); - cant create object of interface
            WoodenDoor d = new WoodenDoor();
            MetalDoor d1 = new MetalDoor();
            d.ShowPicture();

            IDoor[] doors = new IDoor[4]
            {
                new WoodenDoor(),
                new MetalDoor(),
                new MetalDoor(),
                new WoodenDoor()
            };

            foreach (var item in doors)
            {
                item.ShowInfo();
            }

            ShowAboutDoor(d);
            ShowAboutDoor(d1);

            //---lost object---
            d = null;
            //----ELVIS OPERATOR---
            d = d ?? new WoodenDoor();
            d.ShowInfo();

            //---int nullable---

            //  int[] arr = null;// - can do this
            //  arr[0] = null;//---cant't do this, no nullable type int
            Show1(null, 5, null);
            Show2(null);

            //----OPENABLE DOOR---
            Header("OPENABLE DOOR");
            d1.Open();
            d1.ShowInfo();
            d1.Close();
            d1.ShowInfo();

            //OpenClose((IOpenable)d);
            OpenClose(d1);
            d1.ShowInfo();


            Header("ICLONABLE");
            WoodenDoor w5 = (WoodenDoor)d.Clone();
            w5.ShowInfo();

            IDoor newClone = (IDoor) ShowClone((IClonable)doors[1]);
            newClone.ShowInfo();

            Window w = new Window("my very expencive window");
            Window newW = (Window)ShowClone((IClonable)w);
            newW.Show();
        }

        static object ShowClone(IClonable clonable)
        {
            Console.WriteLine("CLONE OBJECT.......");
            return clonable.Clone();
        }

        static void Header(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------"+str+"--------");
            Console.ResetColor();
        }

        static void OpenClose(IOpenable d)
        {
            if (d is IOpenable)
            {
                if (d.IsOpen) d.Close();
                else d.Open();
            }
            else Console.WriteLine("not realizeted interface IOpenable");
        }
        static void Show1(MetalDoor m, int? p, double? d = null)
        {
            int p1 = (int)p;
            m?.ChangePrice(p1);
        }

        static void Show2(int? price)
        {

        }

        static void ShowAboutDoor( IDoor d )
        {
            Console.WriteLine("---NEW DOOR---");
            d.ShowInfo();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(d.GetType().Name);
            Console.ResetColor();
            //---CASE 1--- 
            if (d is WoodenDoor)
                ((WoodenDoor)d).ShowPicture();
            //---CASE 2---
            MetalDoor m = d as MetalDoor;
            if (m != null)
                m.ShowPicture();
            //---CASE 3---
            MetalDoor m1 = d as MetalDoor;
            m1?.ShowPicture();
          
        }
    }
}
