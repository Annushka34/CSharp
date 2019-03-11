using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes_Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mammals m = new Mammals("red");
            //m.Show();

            //Amphibia a = new Amphibia();
            //a.LivePlace = "River";
            //a.Show();

            //Cats c = new Cats();
            //c.Mjau();

            //Animal.LivePlaceAnimal livePlaceAnimal = new Animal.LivePlaceAnimal();

            //Cats m = new Cats();
            //m.Show();

            //    Animal a1 = new Cats();            
            Mammals m1 = new Cats();
            //---explicite // privedenie---
            Mammals m2 = new Dogs();

            // ((Cats)m2).Mjau();
            //---return null if cant be convercions
            Cats newCats = m2 as Cats;
            //  if ( newCats != null )
            newCats?.Mjau();

            if (m2 is Cats)
            {
                ((Cats)m2).Mjau();
            }

            // Amphibia a2 = new Cats();
            //object a2 = new Cats();
            ////var a3 = new Cats();

            //ShowInfo(a2);
            //ShowInfo(m1);
            //ShowInfo(m2);

            //ShowInfo(123);
            //ShowInfo("hello");


            object[] vs = new object[4];
            vs[0] = new Cats();
            vs[1] = new Dogs();
            vs[2] = null;
            vs[3] = new Cats();
            ShowInfo(vs);


        }

        static void ShowInfo(object anim)
        {
            if (anim is Cats)
            {
                Cats c = anim as Cats;
                c.Mjau();
            }
            else if (anim is Dogs)
            {
                Dogs d = anim as Dogs;
                d.Gav();
            }
            else
            {
                Console.WriteLine("No recognized type");
            }
        }
        static void ShowInfo(object[] anim)
        {
            Cats c;
            Dogs d;
            for (int i = 0; i < anim.Length; i++)
            {
                Console.WriteLine(anim[i] ?? "NULL");
                anim[i] = anim[i] ?? new Cats();
                c = anim[i] as Cats;
                //----if object not null  - c? run method from object == if (c != null) c.Mjau()
                c?.Mjau();
                d = anim[i] as Dogs;
                d?.Gav();
            }
        }
    }
}
