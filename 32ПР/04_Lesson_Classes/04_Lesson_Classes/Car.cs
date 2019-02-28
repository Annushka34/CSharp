using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Lesson_Classes
{
    internal class Car //----internal by default---
    {
        int price = 100;
        bool b;
        private Doll _doll;
        private string pswd;

        #region C#5.0
        public string Pswd
        {
           private get { return pswd; }
           set
           {
                if ( value.Length >= 6 && value != pswd)
                    pswd = value;
                else Console.WriteLine("CANT SET VALUE");
           }
        }


        public Doll Doll // ---propfull---snipet--
        {
            private get { return _doll; }
            set { _doll = value; }
        }


        public int GetPrice()
        {
            return price;
        }

        public int Price //---property---
        {
            get
            {
                return price;
            }
            private set
            {
                price = value;
            }
        }

        public int SetPrice
        {
            set
            {
                price = value;
            }
        }
        #endregion

        //-----------------------------------------------------------


        #region C#6.0
        public int CurrentBalance { private get; set; } //---avtoproperty---snipet : prop tab-tab
        #endregion

        #region C#7.0
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        #endregion

        public Car()
        {
            Console.WriteLine($"car price {price} b {b}");
            if (_doll == null)
            {
                Console.WriteLine("d null");
            }
        }

        public void Show()
        {
            Console.WriteLine("---SHOW---");
            Console.WriteLine(Price);
        }
    }
}
