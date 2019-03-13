using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_StandartIterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            var mb = MessageBox.Show("DO you want to continue?", "My MSG", MessageBoxButtons.YesNo);
            Appartmant appartmant = new Appartmant(5) { Address = "Miru 10" };
                appartmant.Rooms[0] = new Room(){roomName = "Bathroom", square = 6};
                appartmant.Rooms[1] = new Room(){ roomName = "Holl", square = 16 };
                appartmant.Rooms[2] = new Room(){ roomName = "VisitRoom", square = 12 };
                appartmant.Rooms[3] = new Room(){ roomName = "BadRoom", square = 14 };
                appartmant.Rooms[4] = new Room() { roomName = "Kitchen", square = 10 };

            //for (int i = 0; i < appartmant.Rooms.Length; i++)
            //{
            //    Console.WriteLine(appartmant.Rooms[i]);
            //}

            Appartmant newClonApp = (Appartmant)appartmant.Clone();

            Header("Original appartment");
            appartmant.Address = "Soborna 15";
            appartmant.Rooms[1].square = 24;
            Console.WriteLine(appartmant.Address);
            foreach (var item in appartmant)
            {
                Console.WriteLine(item);                
            }

            Header("Cloned appartment");
            Console.WriteLine(newClonApp.Address);
            foreach (var item in newClonApp)
            {
                Console.WriteLine(item);
            }

            Header("After sorting by square");
            appartmant.Sort();

            foreach (var item in appartmant)
            {
                Console.WriteLine(item);
            }


            Header("After sorting by name");
            appartmant.SortByName();

            foreach (var item in appartmant)
            {
                Console.WriteLine(item);
            }
        }


        static void Header (string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------"+str+"-------------------");
            Console.ResetColor();
        }
    }
}
