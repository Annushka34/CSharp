using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes_Inherit
{
    abstract class Animal
    {
        private string AnimalType { get; set; }
        public string Color { get; set; }
        //public Animal(): this ("not defined")
        //{
        //    Console.WriteLine("base constructor");
        //}
        //public Animal(string type): this (type, "without color")
        //{
        //   // Console.WriteLine("Create animal");
        //}
        //public Animal(string type, string color)
        //{
        //    AnimalType = type;
        //    Color = color;
        //    Console.WriteLine("Create animal");
        //}

        public Animal(string type = "no defined", string color = "without color")
        {
            AnimalType = type;
            Color = color;
           // Console.WriteLine("Create animal");
        }
        public virtual void Show()
        {
            //Console.WriteLine($"animal type: {AnimalType} color {Color}");
        }

        //---ABSTRACT METHOD !!!!! OBLIGATE TO REALIZATE IN CONCRETE CLASS
        public abstract void SaySmth();

        public class LivePlaceAnimal
        {
            public string PlaceName { get; set; }
            public int Temperature { get; set; }
        }
    }
}
