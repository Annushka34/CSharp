using System;
using System.Collections;

namespace _09_StandartIterfaces
{
    public class Appartmant : IEnumerable, ICloneable
    {
        public string Address { get; set; }
        public Room[] Rooms;
        public Appartmant(int amount)
        {
            Rooms = new Room[amount];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Rooms.GetEnumerator();
        }


        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return new MyEnumerator(Rooms);
        //}

        public void Sort()
        {
            Array.Sort(Rooms);
        }


        public void SortByName()
        {
            Array.Sort(Rooms, new CamparatorRooms());
        }

        public object Clone()
        {
            Appartmant newApp = (Appartmant)this.MemberwiseClone();//----shell copy
            newApp.Rooms = new Room[this.Rooms.Length];
            for (int i = 0; i < this.Rooms.Length; i++)
            {
                newApp.Rooms[i] = new Room() { roomName = this.Rooms[i].roomName, square = this.Rooms[i].square };
            }
            return newApp;
        }
    }


    class MyEnumerator : IEnumerator
    {
        private Room[] rooms;
        private int pos;
        public MyEnumerator(Room [] r)
        {
            rooms = r;
            pos = -1;
        }
        public object Current
        {
            get
            {
                if (pos >= 0 && pos <= rooms.Length)
                    return rooms[pos];
                else throw new Exception();
            }
        }

        object IEnumerator.Current => pos >= 0 && pos < rooms.Length ?  rooms[pos] : throw new Exception("EXEPTION HERE!!!!!!!!!!");

        public bool MoveNext()
        {
            if (pos < rooms.Length)
                pos++;
            return (pos < rooms.Length - 1);
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}
