using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StandartIterfaces
{
    public class Room : IComparable
    {
        public string roomName { set; get; }
        public int square { set; get; }

        public int CompareTo(object obj)
        {
            return this.square.CompareTo((obj as Room).square);
        }

        //public int CompareTo(Room obj)
        //{
        //    return this.square.CompareTo(obj.square);
        //}

        //public int CompareTo(Room obj)
        //{
        //    if (this.square > obj.square) return 1;
        //    if (this.square < obj.square) return -1;
        //    return 0;
        //}

        public override string ToString()
        {
            return "Room: " + roomName + "  square: " + square.ToString();
        }
    }

    class CamparatorRooms : IComparer
    {
        public int Compare(object x, object y)
        {
            return (x as Room).roomName.CompareTo((y as Room).roomName);
        }
    }
}
