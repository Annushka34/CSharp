using _09_StandartIterfaces;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithAppart
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            IRooming rooming = new MyAppartmentWork();
            rooming.AddRoom(new Room { roomName = "new Bedroom", square = r.Next(5, 30) });
            rooming.AddRoom(new Room { roomName = "new Kitchen", square = r.Next(5, 30) });
            rooming.AddRoom(new Room { roomName = "new Holl", square = r.Next(5, 30) });
            rooming.AddRoom(new Room { roomName = "new Bathroom", square = r.Next(5, 30) });
            rooming.AddRoom(new Room { roomName = "new Bedroom", square = r.Next(5, 30) });
            rooming.AddRoom(new Room { roomName = "new Bedroom", square = r.Next(5, 30) });

            rooming.ShowAll();
            //  rooming.ShowRoomByName("new Bedroom");
            Console.WriteLine();
            rooming.RemoveRoom("new Bedroom");
            rooming.ShowAll();
        }
    }


    class MyAppartmentWork : IRooming
    {
        public Appartmant appartmant { get; set; }
        public MyAppartmentWork()
        {
            appartmant = new Appartmant(0);
        }
        public bool AddRoom(object room)
        {
            Array.Resize(ref appartmant.Rooms, appartmant.Rooms.Length + 1);
            appartmant.Rooms[appartmant.Rooms.Length - 1] = (Room)room;
            return true;
        }

        public bool RemoveRoom(string name)
        {
            var rooms = appartmant.Rooms.Where(x => x.roomName != name);
            appartmant.Rooms = rooms.ToArray();
            return true;
        }

        public void ShowAll()
        {
            Console.WriteLine(appartmant.Address);
            foreach (var item in appartmant)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowRoomByName(string name)
        {
            var rooms = appartmant.Rooms.Where(x => x.roomName == name);
            foreach (var item in rooms)
            {
                Console.WriteLine(item);
            }
        }
    }
}
